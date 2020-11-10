using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image image;

    public Item item;

    public int slotId = -1;
    public ItemType slotItemType = ItemType.None;

    public void Start()
    {
        // When the inventory is opened for the first time, 
        // if there is an item in the slot, set the slot's sprite to item's sprite,
        // set it's type to slot item type
        if (item.id != -1)
            image.sprite = ItemManager.Instance.itemProperties[item.id].sprite;
    }

    public void OnPointerEnter()
    {
        Debug.Log($"Entered to {slotId}");
        // Since the mouse hovering on the slot, enable slot shadow on the slot's position
        ItemSlotShadow.Instance.Enable(transform.position);
        StartCoroutine(ShowItemProperty());
    }

    public void OnPointerExit()
    {
        Debug.Log($"Exited from {slotId}");
        // Since the mouse is not anymore hovering on the slot, disable the slot shadow
        ItemSlotShadow.Instance.Disable();
        StartCoroutine(DisablePropertyDisplayer());
    }

    public void OnPointerClick()
    {
        Debug.Log($"Clicked at {slotId}");
        bool itemChanged = ItemHolder.Instance.HoldItem(ref item, slotItemType, slotId);
        if (itemChanged)
        {
            if (item.id == -1)
                image.sprite = ImageManager.Instance.transparent1x1;
            else
                image.sprite = ItemManager.Instance.itemProperties[item.id].sprite;
        }
    }

    private IEnumerator ShowItemProperty()
    {
        if (item.id != -1)
        {
            yield return new WaitForSeconds(0.25f);

            // Check if after 0.25 seconds, there is still an
            // item in the slot, if not, then exit this function
            if (item.id == -1)
                yield break;

            // Show item's properties
            Vector3 slotPos = transform.position;
            ItemPropertyDisplayer.Instance.SetDisplay(slotPos, ref item);
            ItemPropertyDisplayer.Instance.gameObject.SetActive(true);
        }
    }

    private IEnumerator DisablePropertyDisplayer()
    {
        yield return new WaitForSeconds(0.1f);

        if (!ItemPropertyDisplayer.Instance.hovered)
        {
            StopAllCoroutines();
            ItemPropertyDisplayer.Instance.gameObject.SetActive(false);
        }
    }
}
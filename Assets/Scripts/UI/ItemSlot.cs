using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image image;

    public Item item;

    public int slotId = -1;
    public SlotType slotType = SlotType.Any;

    public void Start()
    {
        // When the inventory is opened for the first time, 
        // if there is an item in the slot, set the slot's sprite to item's sprite
        if (item.id != -1)
            image.sprite = ItemManager.Instance.itemProperties[item.id].sprite;
    }

    public void OnPointerEnter()
    {
        Debug.Log($"Entered to {slotId}");
        // Since the mouse hovering on the slot, enable slot shadow on the slot's position
        ItemSlotShadow.Enable(transform.position);
    }

    public void OnPointerExit()
    {
        Debug.Log($"Exited from {slotId}");
        // Since the mouse is not anymore hovering on the slot, disable the slot shadow
        ItemSlotShadow.Disable();
    }

    public void OnPointerClick()
    {
        Debug.Log($"Clicked at {slotId}");
        bool itemChanged = ItemHolder.Instance.HoldItem(ref item, slotType, slotId);
        if (itemChanged)
        {
            if (item.id == -1)
                image.sprite = ImageManager.Instance.transparent1x1;
            else
                image.sprite = ItemManager.Instance.itemProperties[item.id].sprite;
        }
    }
}

public enum SlotType
{
    Any = -1,
    Armor,
    Weapon,
    Accessory
}
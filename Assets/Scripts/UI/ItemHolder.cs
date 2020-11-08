using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ItemHolder : MonoBehaviour
{
    public static ItemHolder Instance;

    public Image image;

    private bool holdingItem = false;
    private Item itemHeld = new Item(-1);
    private int emptySlotId = -1;
    private SlotType emptySlotType = SlotType.Any;

    // Called by UIManager.Init when the game starts
    public void Init()
    {
        Instance = this;
    }

    public bool HoldItem(ref Item _item, SlotType _slotType, int _slotId)
    {
        if (itemHeld.id != -1 && _slotType != SlotType.Any && (int)ItemManager.Instance.itemProperties[itemHeld.id].itemType != (int)_slotType)
            return false;

        if (holdingItem)
        {
            // If there is no item in the item slot
            if (_item.id == -1)
            {
                image.enabled = false;
                holdingItem = false;
                StopAllCoroutines();
                _item = itemHeld;
                itemHeld = new Item(-1);
                emptySlotId = -1;
                emptySlotType = SlotType.Any;

                return true;
            }
            else    // If there is an item in the item slot
            {
                Item oldItem = itemHeld;
                itemHeld = _item;
                image.sprite = ItemManager.Instance.itemProperties[_item.id].sprite;
                _item = oldItem;

                return true;
            }
        }
        else
        {
            if (_item.id == -1)
                return false;

            itemHeld = _item;
            emptySlotId = _slotId;
            emptySlotType = _slotType;
            _item = new Item(-1);
            image.sprite = ItemManager.Instance.itemProperties[itemHeld.id].sprite;
            image.enabled = true;
            holdingItem = true;
            StartCoroutine(Instance.StartHoldingItem());

            return true;
        }
    }

    public void StopHoldingItem()
    {
        if (itemHeld.id != -1)
        {
            switch (emptySlotType)
            {
                case SlotType.Any:
                    InventoryManager.Instance.inventoryItemSlots[emptySlotId].item = itemHeld;
                    InventoryManager.Instance.inventoryItemSlots[emptySlotId].image.sprite = ItemManager.Instance.itemProperties[itemHeld.id].sprite;
                    break;
                case SlotType.Armor:
                case SlotType.Weapon:
                case SlotType.Accessory:
                    InventoryManager.Instance.equipmentItemSlots[emptySlotId].item = itemHeld;
                    InventoryManager.Instance.equipmentItemSlots[emptySlotId].image.sprite = ItemManager.Instance.itemProperties[itemHeld.id].sprite;
                    break;
                default:
                    Debug.LogError($"There is no slot type with Id {(int)emptySlotType}");
                    break;
            }
            itemHeld = new Item(-1);
            image.enabled = false;
            holdingItem = false;
            StopAllCoroutines();
        }
    }

    private IEnumerator StartHoldingItem()
    {
        while (holdingItem)
        {
            Vector2 holdPos = Game.Instance.cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = holdPos;

            yield return null;
        }
    }
}

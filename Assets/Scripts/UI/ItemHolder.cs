using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class ItemHolder : MonoBehaviour
{
    public static ItemHolder Instance;

    public Image image;

    private bool holdingItem = false;
    private Item itemHeld = new Item(-1);
    private int holderSlotId = -1;
    private ItemType holderItemType = ItemType.None;

    // Called by UIManager.Init when the game starts
    public void Init()
    {
        Instance = this;
    }

    public bool HoldItem(ref Item _item, ItemType _slotItemType, int _slotId)
    {
        // If there is no item held & 
        if (itemHeld.id != -1 && _slotItemType != ItemType.Any && (int)ItemManager.Instance.itemProperties[itemHeld.id].itemType != (int)_slotItemType)
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
                holderSlotId = -1;
                holderItemType = ItemType.None;

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
            holderSlotId = _slotId;
            holderItemType = _slotItemType;
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
            switch (holderItemType)
            {
                case ItemType.None:
                    InventoryManager.Instance.inventoryItemSlots[holderSlotId].item = itemHeld;
                    InventoryManager.Instance.inventoryItemSlots[holderSlotId].image.sprite = ItemManager.Instance.itemProperties[itemHeld.id].sprite;
                    break;
                case ItemType.Armor_Helmet:
                case ItemType.Armor_Chestplate:
                case ItemType.Armor_Leggings:
                case ItemType.Armor_Boots:
                case ItemType.Weapon_Sword:
                case ItemType.Weapon_Bow:
                case ItemType.Weapon_Staff:
                case ItemType.Accessory:
                    InventoryManager.Instance.equipmentItemSlots[holderSlotId].item = itemHeld;
                    InventoryManager.Instance.equipmentItemSlots[holderSlotId].image.sprite = ItemManager.Instance.itemProperties[itemHeld.id].sprite;
                    break;
                default:
                    Debug.LogError($"There is no item type with Id {(int)holderItemType}");
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

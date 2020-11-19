using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDisplayer : MonoBehaviour
{
    public static PlayerDisplayer Instance;

    public Sprite[] models;

    public Image modelHelmet;
    public Image modelChestplate;
    public Image modelLeggings;
    public Image modelBoots;
    public Image modelWeapon;


    // Called by UIManager.Init when the game starts
    public void Init()
    {
        Instance = this;
    }

    public void ChangeModel(int _itemId, ItemType _type)
    {
        switch (_type)
        {
            case ItemType.Armor_Helmet:
                if (_itemId == -1)
                    modelHelmet.sprite = ImageManager.Instance.transparent1x1;
                else
                    modelHelmet.sprite = models[_itemId];

                break;
            case ItemType.Armor_Chestplate:
                if (_itemId == -1)
                    modelChestplate.sprite = ImageManager.Instance.transparent1x1;
                else
                    modelChestplate.sprite = models[_itemId];

                break;
            case ItemType.Armor_Leggings:
                if (_itemId == -1)
                    modelLeggings.sprite = ImageManager.Instance.transparent1x1;
                else
                    modelLeggings.sprite = models[_itemId];

                break;
            case ItemType.Armor_Boots:
                if (_itemId == -1)
                    modelBoots.sprite = ImageManager.Instance.transparent1x1;
                else
                    modelBoots.sprite = models[_itemId];

                break;
            case ItemType.Weapon_Sword:
            case ItemType.Weapon_Bow:
            case ItemType.Weapon_Staff:
                if (_itemId == -1)
                    modelWeapon.sprite = ImageManager.Instance.transparent1x1;
                else
                    modelWeapon.sprite = ItemManager.Instance.itemProperties[_itemId].sprite;
                
                break;
            case ItemType.Accessory:
                break;
            default:
                Debug.LogError($"No item type with id: { (int)_type }");
                break;
        }
    }
}

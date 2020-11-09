using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[System.Serializable]
public class ItemProperty
{
    public string name;
    [TextArea(1, 3)]
    public string description;
    public int id;
    public ItemType itemType;
    public Sprite sprite;
}

[System.Serializable]
public class Item
{
    public int id = -1;

    public Item(int _id)
    {
        id = _id;
    }

    public static bool operator ==(Item a, Item b)
    {
        if (ItemManager.Instance.itemProperties[a.id].itemType == ItemManager.Instance.itemProperties[b.id].itemType)
            return true;

        return false;
    }

    public static bool operator !=(Item a, Item b)
    {
        return !(a == b);
    }
}

public enum ItemType
{
    None = -1,
    Any,
    Armor_Helmet,
    Armor_Chestplate,
    Armor_Leggings,
    Armor_Boots,
    Weapon_Sword,
    Weapon_Bow,
    Weapon_Staff,
    Accessory
}
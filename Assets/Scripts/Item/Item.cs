using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
}

public enum ItemType
{
    Armor,
    Weapon,
    Accessory
}
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro.EditorUtilities;
using UnityEngine;

[System.Serializable]
public class ItemProperty
{
    public string name;
    public string description;
    public ItemType itemType;
    public int id;
    public Sprite sprite;
    public Modifier[] modifiers;

    public ItemProperty(string _name, string _description, ItemType _itemType, int _id, string _spritePath, Modifier[] _modifiers)
    {
        name = _name;
        description = _description;
        itemType = _itemType;
        id = _id;

        sprite = Resources.Load<Sprite>(_spritePath);

        modifiers = new Modifier[(int)ModifierType.Count];
        int modifierLength = _modifiers != null ? _modifiers.Length : 0;
        for (int i = 0; i < modifierLength; ++i)
        {
            int typeId = (int)_modifiers[i].type;
            modifiers[typeId] = new Modifier(typeId, _modifiers[i].values);
        }
    }
}

[System.Serializable]
public class Item
{
    public int id = -1;
    public ItemDurability durability = ItemDurability.None;

    public Item(int _id)
    {
        id = _id;
        durability = ItemDurability.None;
    }

    public Item(int _id, ItemDurability _durability)
    {
        id = _id;
        durability = _durability;
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

public enum ItemDurability
{
    None = -1,
    Low,
    Medium,
    High
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

[System.Serializable]
public class Modifier
{
    public ModifierType type;
    public int[] values;

    public Modifier(ModifierType _type, int[] _values)
    {
        type = _type;
        values = _values;
    }

    public Modifier(int _modifierId, int[] _values)
    {
        type = (ModifierType)_modifierId;
        values = _values;
    }

    public override string ToString()
    {
        string value = "";

        switch (type)
        {
            case ModifierType.None:
                value = "None";
                break;
            case ModifierType.Health_Point:
                value = "Health Point";
                break;
            case ModifierType.Attack_Damage:
                value = "Attack Damage";
                break;
            case ModifierType.Ability_Power:
                value = "Ability Power";
                break;
            case ModifierType.Armor:
                value = "Armor";
                break;
            case ModifierType.Magic_Resist:
                value = "Magic Resist";
                break;
            case ModifierType.Armor_Penetration:
                value = "Armor Penetration";
                break;
            case ModifierType.Magic_Penetration:
                value = "Magic Penetration";
                break;
            case ModifierType.Critical_Strike:
                value = "Critical Strike";
                break;
            case ModifierType.Block:
                value = "Block";
                break;
            default:
                Debug.LogError($"Error: No type with id {(int)type}"); ;
                break;
        }

        return value;
    }
}

public enum ModifierType
{
    None = -1,
    Health_Point,
    Attack_Damage,
    Ability_Power,
    Armor,
    Magic_Resist,
    Armor_Penetration,
    Magic_Penetration,
    Critical_Strike,
    Block,
    Count   // Count of all modifier types
}
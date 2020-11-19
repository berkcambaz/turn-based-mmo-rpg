using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;

    public ItemProperty[] itemProperties;

    // Called by Game when the game starts
    public void Init()
    {
        Instance = this;

        InitItems();
    }

    private void InitItems()
    {
        itemProperties = new ItemProperty[42];

        int index = 0;
        string basePath;



        basePath = "Sprites/Armors/Helmets/";
        #region Helmet

        #region Leather Helmet
        itemProperties[index++] = new ItemProperty(
            "Leather Helmet",
            "",
            ItemType.Armor_Helmet,
            index,
            basePath + "leather_helmet",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 24, 32, 40 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 24, 32, 40 })
            });
        #endregion

        #region Chainmail Helmet
        itemProperties[index++] = new ItemProperty(
            "Chainmail Helmet",
            "",
            ItemType.Armor_Helmet,
            index,
            basePath + "chainmail_helmet",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 96, 128, 150 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 96, 128, 150 })
            });
        #endregion

        #region Iron Helmet
        itemProperties[index++] = new ItemProperty(
            "Iron Helmet",
            "",
            ItemType.Armor_Helmet,
            index,
            basePath + "iron_helmet",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 384, 512, 640 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 384, 512, 640 })
            });
        #endregion

        #region Gold Helmet
        itemProperties[index++] = new ItemProperty(
            "Gold Helmet",
            "",
            ItemType.Armor_Helmet,
            index,
            basePath + "gold_helmet",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 1536, 2048, 2560 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 1536, 2048, 2560 })
            });
        #endregion

        #region Netherite Helmet
        itemProperties[index++] = new ItemProperty(
            "Netherite Helmet",
            "",
            ItemType.Armor_Helmet,
            index,
            basePath + "netherite_helmet",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 6144, 8192, 10240 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 6144, 8192, 10240 })
            });
        #endregion

        #region Diamond Helmet
        itemProperties[index++] = new ItemProperty(
            "Diamond Helmet",
            "",
            ItemType.Armor_Helmet,
            index,
            basePath + "diamond_helmet",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 24576, 32768, 40960 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 24576, 32768, 40960 })
            });
        #endregion

        #endregion

        basePath = "Sprites/Armors/Chestplates/";
        #region Chestplate

        #region Leather Chestplate
        itemProperties[index++] = new ItemProperty(
            "Leather Chestplate",
            "",
            ItemType.Armor_Chestplate,
            index,
            basePath + "leather_chestplate",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 24, 32, 40 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 24, 32, 40 })
            });
        #endregion

        #region Chainmail Chestplate
        itemProperties[index++] = new ItemProperty(
            "Chainmail Chestplate",
            "",
            ItemType.Armor_Chestplate,
            index,
            basePath + "chainmail_chestplate",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 96, 128, 150 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 96, 128, 150 })
            });
        #endregion

        #region Iron Chestplate
        itemProperties[index++] = new ItemProperty(
            "Iron Chestplate",
            "",
            ItemType.Armor_Chestplate,
            index,
            basePath + "iron_chestplate",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 384, 512, 640 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 384, 512, 640 })
            });
        #endregion

        #region Gold Chestplate
        itemProperties[index++] = new ItemProperty(
            "Gold Chestplate",
            "",
            ItemType.Armor_Chestplate,
            index,
            basePath + "gold_chestplate",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 1536, 2048, 2560 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 1536, 2048, 2560 })
            });
        #endregion

        #region Netherite Chestplate
        itemProperties[index++] = new ItemProperty(
            "Netherite Chestplate",
            "",
            ItemType.Armor_Chestplate,
            index,
            basePath + "netherite_chestplate",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 6144, 8192, 10240 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 6144, 8192, 10240 })
            });
        #endregion

        #region Diamond Chestplate
        itemProperties[index++] = new ItemProperty(
            "Diamond Chestplate",
            "",
            ItemType.Armor_Chestplate,
            index,
            basePath + "diamond_chestplate",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 24576, 32768, 40960 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 24576, 32768, 40960 })
            });
        #endregion

        #endregion

        basePath = "Sprites/Armors/Leggings/";
        #region Leggings

        #region Leather Leggings
        itemProperties[index++] = new ItemProperty(
            "Leather Leggings",
            "",
            ItemType.Armor_Leggings,
            index,
            basePath + "leather_leggings",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 24, 32, 40 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 24, 32, 40 })
            });
        #endregion

        #region Chainmail Leggings
        itemProperties[index++] = new ItemProperty(
            "Chainmail Leggings",
            "",
            ItemType.Armor_Leggings,
            index,
            basePath + "chainmail_leggings",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 96, 128, 150 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 96, 128, 150 })
            });
        #endregion

        #region Iron Leggings
        itemProperties[index++] = new ItemProperty(
            "Iron Leggings",
            "",
            ItemType.Armor_Leggings,
            index,
            basePath + "iron_leggings",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 384, 512, 640 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 384, 512, 640 })
            });
        #endregion

        #region Gold Leggings
        itemProperties[index++] = new ItemProperty(
            "Gold Leggings",
            "",
            ItemType.Armor_Leggings,
            index,
            basePath + "gold_leggings",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 1536, 2048, 2560 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 1536, 2048, 2560 })
            });
        #endregion

        #region Netherite Leggings
        itemProperties[index++] = new ItemProperty(
            "Netherite Leggings",
            "",
            ItemType.Armor_Leggings,
            index,
            basePath + "netherite_leggings",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 6144, 8192, 10240 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 6144, 8192, 10240 })
            });
        #endregion

        #region Diamond Leggings
        itemProperties[index++] = new ItemProperty(
            "Diamond Leggings",
            "",
            ItemType.Armor_Leggings,
            index,
            basePath + "diamond_leggings",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 24576, 32768, 40960 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 24576, 32768, 40960 })
            });
        #endregion

        #endregion

        basePath = "Sprites/Armors/Boots/";
        #region Boots

        #region Leather Boots
        itemProperties[index++] = new ItemProperty(
            "Leather Boots",
            "",
            ItemType.Armor_Boots,
            index,
            basePath + "leather_boots",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 24, 32, 40 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 24, 32, 40 })
            });
        #endregion

        #region Chainmail Boots
        itemProperties[index++] = new ItemProperty(
            "Chainmail Boots",
            "",
            ItemType.Armor_Boots,
            index,
            basePath + "chainmail_boots",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 96, 128, 150 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 96, 128, 150 })
            });
        #endregion

        #region Iron Boots
        itemProperties[index++] = new ItemProperty(
            "Iron Boots",
            "",
            ItemType.Armor_Boots,
            index,
            basePath + "iron_boots",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 384, 512, 640 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 384, 512, 640 })
            });
        #endregion

        #region Gold Boots
        itemProperties[index++] = new ItemProperty(
            "Gold Boots",
            "",
            ItemType.Armor_Boots,
            index,
            basePath + "gold_boots",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 1536, 2048, 2560 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 1536, 2048, 2560 })
            });
        #endregion

        #region Netherite Boots
        itemProperties[index++] = new ItemProperty(
            "Netherite Boots",
            "",
            ItemType.Armor_Boots,
            index,
            basePath + "netherite_boots",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 6144, 8192, 10240 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 6144, 8192, 10240 })
            });
        #endregion

        #region Diamond Boots
        itemProperties[index++] = new ItemProperty(
            "Diamond Boots",
            "",
            ItemType.Armor_Boots,
            index,
            basePath + "diamond_boots",
            new Modifier[] {
                new Modifier(ModifierType.Armor, new int[] { 24576, 32768, 40960 }),
                new Modifier(ModifierType.Magic_Resist, new int[] { 24576, 32768, 40960 })
            });
        #endregion

        #endregion

        basePath = "Sprites/Weapons/Swords/";
        #region Swords

        #region Wood Sword
        itemProperties[index++] = new ItemProperty(
            "Wood Sword",
            "",
            ItemType.Weapon_Sword,
            index,
            basePath + "wood_sword",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 24, 32, 40 })
            });
        #endregion

        #region Stone Sword
        itemProperties[index++] = new ItemProperty(
            "Stone Sword",
            "",
            ItemType.Weapon_Sword,
            index,
            basePath + "stone_sword",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 96, 128, 150 })
            });
        #endregion

        #region Iron Sword
        itemProperties[index++] = new ItemProperty(
            "Iron Sword",
            "",
            ItemType.Weapon_Sword,
            index,
            basePath + "iron_sword",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 384, 512, 640 })
            });
        #endregion

        #region Gold Sword
        itemProperties[index++] = new ItemProperty(
            "Gold Sword",
            "",
            ItemType.Weapon_Sword,
            index,
            basePath + "gold_sword",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 1536, 2048, 2560 })
            });
        #endregion

        #region Netherite Sword
        itemProperties[index++] = new ItemProperty(
            "Netherite Sword",
            "",
            ItemType.Weapon_Sword,
            index,
            basePath + "netherite_sword",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 6144, 8192, 10240 })
            });
        #endregion

        #region Diamond Sword
        itemProperties[index++] = new ItemProperty(
            "Diamond Sword",
            "",
            ItemType.Weapon_Sword,
            index,
            basePath + "diamond_sword",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 24576, 32768, 40960 })
            });
        #endregion

        #endregion

        basePath = "Sprites/Weapons/Bows/";
        #region Bows

        #region Wood Bow
        itemProperties[index++] = new ItemProperty(
            "Wood Bow",
            "",
            ItemType.Weapon_Bow,
            index,
            basePath + "wood_bow",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 24, 32, 40 })
            });
        #endregion

        #region Stone Bow
        itemProperties[index++] = new ItemProperty(
            "Stone Bow",
            "",
            ItemType.Weapon_Bow,
            index,
            basePath + "stone_bow",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 96, 128, 150 })
            });
        #endregion

        #region Iron Bow
        itemProperties[index++] = new ItemProperty(
            "Iron Bow",
            "",
            ItemType.Weapon_Bow,
            index,
            basePath + "iron_bow",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 384, 512, 640 })
            });
        #endregion

        #region Gold Bow
        itemProperties[index++] = new ItemProperty(
            "Gold Bow",
            "",
            ItemType.Weapon_Bow,
            index,
            basePath + "gold_bow",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 1536, 2048, 2560 })
            });
        #endregion

        #region Netherite Bow
        itemProperties[index++] = new ItemProperty(
            "Netherite Bow",
            "",
            ItemType.Weapon_Bow,
            index,
            basePath + "netherite_bow",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 6144, 8192, 10240 })
            });
        #endregion

        #region Diamond Bow
        itemProperties[index++] = new ItemProperty(
            "Diamond Bow",
            "",
            ItemType.Weapon_Bow,
            index,
            basePath + "diamond_bow",
            new Modifier[] {
                new Modifier(ModifierType.Attack_Damage, new int[] { 24576, 32768, 40960 })
            });
        #endregion

        #endregion

        basePath = "Sprites/Weapons/Staffs/";
        #region Staffs

        #region Wood Staff
        itemProperties[index++] = new ItemProperty(
            "Wood Staff",
            "",
            ItemType.Weapon_Staff,
            index,
            basePath + "    wood_staff",
            new Modifier[] {
                new Modifier(ModifierType.Ability_Power, new int[] { 24, 32, 40 })
            });
        #endregion

        #region Stone Staff
        itemProperties[index++] = new ItemProperty(
            "Stone Staff",
            "",
            ItemType.Weapon_Staff,
            index,
            basePath + "stone_staff",
            new Modifier[] {
                new Modifier(ModifierType.Ability_Power, new int[] { 96, 128, 150 })
            });
        #endregion

        #region Iron Staff
        itemProperties[index++] = new ItemProperty(
            "Iron Staff",
            "",
            ItemType.Weapon_Staff,
            index,
            basePath + "iron_staff",
            new Modifier[] {
                new Modifier(ModifierType.Ability_Power, new int[] { 384, 512, 640 })
            });
        #endregion

        #region Gold Staff
        itemProperties[index++] = new ItemProperty(
            "Gold Staff",
            "",
            ItemType.Weapon_Staff,
            index,
            basePath + "gold_staff",
            new Modifier[] {
                new Modifier(ModifierType.Ability_Power, new int[] { 1536, 2048, 2560 })
            });
        #endregion

        #region Netherite Staff
        itemProperties[index++] = new ItemProperty(
            "Netherite Staff",
            "",
            ItemType.Weapon_Staff,
            index,
            basePath + "netherite_staff",
            new Modifier[] {
                new Modifier(ModifierType.Ability_Power, new int[] { 6144, 8192, 10240 })
            });
        #endregion

        #region Diamond Staff
        itemProperties[index++] = new ItemProperty(
            "Diamond Staff",
            "",
            ItemType.Weapon_Staff,
            index,
            basePath + "diamond_staff",
            new Modifier[] {
                new Modifier(ModifierType.Ability_Power, new int[] { 24576, 32768, 40960 })
            });
        #endregion

        #endregion
    }
}

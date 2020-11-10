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
        itemProperties = new ItemProperty[18];

        int index = 0;
        string basePath;

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
                new Modifier(ModifierType.Attack_Damage, new int[] { 24, 32, 40 }),
                new Modifier(ModifierType.Ability_Power, new int[] { 24, 32, 40 })
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

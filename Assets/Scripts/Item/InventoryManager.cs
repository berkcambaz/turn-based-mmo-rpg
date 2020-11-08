using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public Transform inventoryItems;

    [System.NonSerialized]
    public ItemSlot[] inventoryItemSlots;   // Automatically set from the code
    public ItemSlot[] equipmentItemSlots;   // Manually set from editor

    // Called by Game when the game starts
    public void Init()
    {
        Instance = this;

        // Get each inventory item slot and equipment item slot
        // from the inventory item's transform
        /* Order of gameobjects in the hierarchy window */
        // - Inventory Items
        //   - Row (1)
        //     - Item Slot (1)
        //     - Item Slot (2)
        //     - ...
        //   - Row (2)
        //     - Item Slot (1)
        //     - Item Slot (2)
        //     - ...
        //   - ...
        int rowCount = inventoryItems.childCount;
        int colCount = inventoryItems.GetChild(0).childCount;
        inventoryItemSlots = new ItemSlot[rowCount * colCount];
        for (int r = 0; r < rowCount; ++r)
        {
            Transform row = inventoryItems.GetChild(r);
            for (int c = 0; c < colCount; ++c)
            {
                inventoryItemSlots[c + r * colCount] = row.GetChild(c).GetComponent<ItemSlot>();
            }
        }
    }
}

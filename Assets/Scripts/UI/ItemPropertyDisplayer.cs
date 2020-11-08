using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPropertyDisplayer : MonoBehaviour
{
    public static ItemPropertyDisplayer Instance;

    public Text itemName;
    public Text itemDescription;

    // Called by UIManager.Init when the game starts
    public void Init()
    {
        Instance = this;
    }

    public void SetDisplay(Vector3 _pos, int _itemId)
    {
        transform.position = _pos;
        //Debug.Log(transform.position);
        itemName.text = ItemManager.Instance.itemProperties[_itemId].name;
        itemDescription.text = ItemManager.Instance.itemProperties[_itemId].description;
    }
}

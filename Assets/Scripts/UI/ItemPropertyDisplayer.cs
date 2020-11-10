using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPropertyDisplayer : MonoBehaviour
{
    public static ItemPropertyDisplayer Instance;

    public Text itemName;
    public Text itemDescription;

    public bool hovered = false;

    // Called by UIManager.Init when the game starts
    public void Init()
    {
        Instance = this;
    }

    public void SetDisplay(Vector3 _pos, ref Item _item)
    {
        transform.position = _pos;
        Debug.Log(transform.position);
        itemName.text = ItemManager.Instance.itemProperties[_item.id].name;
        itemDescription.text = ItemManager.Instance.itemProperties[_item.id].description;
        ItemModifierManager.Instance.SetModifiers(ref _item);
    }

    public void OnPointerEnter()
    {
        hovered = true;
    }

    public void OnPointerExit()
    {
        gameObject.SetActive(false);
        hovered = false;
    }
}

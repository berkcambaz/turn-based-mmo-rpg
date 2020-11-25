using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPropertyDisplayer : MonoBehaviour
{
    public static ItemPropertyDisplayer Instance;

    public Text itemName;
    public Text itemDescription;

    public RectTransform containerTop;
    public RectTransform containerMiddle;
    public RectTransform containerBottom;

    public bool hovered = false;

    // Called by UIManager.Init when the game starts
    public void Init()
    {
        Instance = this;
    }

    public void SetDisplay(Vector3 _pos, Item _item)
    {
        transform.position = _pos;
        itemName.text = ItemManager.Instance.itemProperties[_item.id].name;
        itemDescription.text = ItemManager.Instance.itemProperties[_item.id].description;
        ItemModifierManager.Instance.SetModifiers(ref _item);

        gameObject.SetActive(true);

        LayoutRebuilder.ForceRebuildLayoutImmediate(containerTop);
        LayoutRebuilder.ForceRebuildLayoutImmediate(containerMiddle);
        LayoutRebuilder.ForceRebuildLayoutImmediate(containerBottom);

        float totalHeight = containerTop.sizeDelta.y + containerMiddle.sizeDelta.y + containerBottom.sizeDelta.y;
        Vector2 totalSize = new Vector2(containerMiddle.sizeDelta.x, totalHeight);

        Vector2 screenPos = Game.Instance.cam.WorldToScreenPoint(_pos);
        if (screenPos.x + totalSize.x > Screen.width)
        {
            float dt = screenPos.x + totalSize.x - Screen.width;
            screenPos.x -= dt;
        }
        else if (0f > screenPos.x - totalSize.x)
        {
            Debug.Log("left");
        }

        if (screenPos.y + totalSize.y / 2f > Screen.height)
        {
            Debug.Log("up");
        }
        else if (0f > screenPos.y - totalSize.y / 2f)
        {
            Debug.Log("down");
        }
        
        transform.position = Game.Instance.cam.ScreenToWorldPoint(screenPos);
    }

    public void OnPointerEnter()
    {
        hovered = true;
    }

    public void OnPointerExit()
    {
        //gameObject.SetActive(false);
        //hovered = false;
    }
}

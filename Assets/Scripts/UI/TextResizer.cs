using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextResizer : MonoBehaviour
{
    public Text text;
    public LayoutElement layoutElement;

    public int textCharLength;
    public int increaseHeight;
    private Vector2 defaultSize = -Vector2.one;

    public void OnEnable()
    {
        if (defaultSize == -Vector2.one)
            defaultSize = text.rectTransform.sizeDelta;
        CheckTextSize();
    }

    private void CheckTextSize()
    {
        string str = text.text;

        if (str.Length == 0) { 
            layoutElement.preferredHeight = 0;
            return;
        }

        int ratio = 0;
        int index = 0;

        while (true)
        {
            index = str.IndexOf("\n", index) + 1;
            if (index == 0)
                break;
            ++ratio;
        }

        layoutElement.preferredHeight = defaultSize.y + (ratio * increaseHeight);
    }
}

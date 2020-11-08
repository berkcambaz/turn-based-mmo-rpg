using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextResizer : MonoBehaviour
{
    public Text text;
    public int textCharLength;
    public int increaseHeight;

    public void OnEnable()
    {
        CheckTextSize();
    }

    private void CheckTextSize()
    {
        string str = text.text;
        int ratio = 0;
        int index = 0;

        while (true)
        {
            index = str.IndexOf("\n", index) + 1;
            if (index == 0)
                break;
            ++ratio;
        }

        Vector2 sizeDt = new Vector2(text.rectTransform.sizeDelta.x, text.rectTransform.sizeDelta.y + (ratio * increaseHeight));
        text.rectTransform.sizeDelta = sizeDt;
    }
}

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

        // Give each item an id according to their order
        // since it's harder to set them from the editor
        int length = itemProperties.Length;
        for (int i = 0; i < length; ++i)
            itemProperties[i].id = i;
    }
}

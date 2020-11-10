using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ItemModifierManager : MonoBehaviour
{
    public static ItemModifierManager Instance;

    public Text[] modifierText;
    public Text[] valueText;

    // Called by Game when the game starts
    public void Init()
    {
        Instance = this;
    }

    public void SetModifiers(ref Item _item)
    {
        ref ItemProperty properties = ref ItemManager.Instance.itemProperties[_item.id];
        int modifierLength = properties.modifiers.Length;
        for (int i = 0; i < modifierLength; ++i)
        {
            if (properties.modifiers[i] != null)
            {
                modifierText[i].text = properties.modifiers[i].ToString();

                int durability = (int)_item.durability;
                // If durability is none, don't show the durability bar & 
                // use durability as 0
                if (durability == -1)
                {
                    valueText[i].text = properties.modifiers[i].values[0].ToString();
                }
                else
                {
                    // TODO: Show durability bar
                    valueText[i].text = properties.modifiers[i].values[(int)_item.durability].ToString();
                }

                modifierText[i].gameObject.SetActive(true);
            }
            else
            {
                modifierText[i].gameObject.SetActive(false);
            }
        }
    }
}

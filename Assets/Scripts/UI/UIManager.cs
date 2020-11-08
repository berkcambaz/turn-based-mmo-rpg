using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Canvas inventoryCanvas;
    public Canvas skillsCanvas;
    public Canvas smithingCanvas;
    public Canvas mapCanvas;

    public ItemHolder itemHolder;

    private bool inventoryTabOpened = false;
    private bool skillsTabOpened = false;
    private bool smithingTabOpened = false;
    private bool mapTabOpened = false;

    // Called by Game when the game starts
    public void Init()
    {
        itemHolder.Init();
    }

    // This function is called by UI buttons
    public void ClickedToTab(string _tabName)
    {
        switch (_tabName)
        {
            case "Inventory":
                ClickToTab(UITab.Inventory);
                break;
            case "Skills":
                ClickToTab(UITab.Skills);
                break;
            case "Smithing":
                ClickToTab(UITab.Smithing);
                break;
            case "Map":
                ClickToTab(UITab.Map);
                break;
            default:
                Debug.LogError($"There is no tab name called {_tabName}");
                break;
        }
    }

    // This function should only be called from scripts
    /* Opens or closes the input UI tab */
    public void ClickToTab(UITab _uiTab)
    {
        switch (_uiTab)
        {   
            case UITab.Inventory:
                inventoryTabOpened = !inventoryTabOpened;
                inventoryCanvas.gameObject.SetActive(inventoryTabOpened);
                ItemHolder.Instance.StopHoldingItem();
                break;
            case UITab.Skills:
                skillsTabOpened = !skillsTabOpened;
                skillsCanvas.gameObject.SetActive(skillsTabOpened);
                break;
            case UITab.Smithing:
                smithingTabOpened = !smithingTabOpened;
                smithingCanvas.gameObject.SetActive(smithingTabOpened);
                break;
            case UITab.Map:
                mapTabOpened = !mapTabOpened;
                mapCanvas.gameObject.SetActive(mapTabOpened);
                break;
            default:
                Debug.LogError($"There is UI tab called {_uiTab}");
                break;
        }
    }
}

public enum UITab
{
    Inventory,
    Skills,
    Smithing,
    Map
}
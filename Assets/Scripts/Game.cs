using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game Instance;

    public Camera cam;
    public float aspectRatio;

    // --- Manager scripts --- //
    public ImageManager imageManager;
    public InventoryManager inventoryManager;
    public ItemManager itemManager;
    public UIManager uiManager;

    void Awake()
    {
        Instance = this;

        aspectRatio = (Screen.width / 1920f) / (Screen.height / 1080f);

        // Initialize all manager scripts
        InitManagers();

        Application.targetFrameRate = 60;
    }

    private void InitManagers()
    {
        imageManager.Init();
        inventoryManager.Init();
        itemManager.Init();
        uiManager.Init();
    }
}

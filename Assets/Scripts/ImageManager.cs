using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageManager : MonoBehaviour
{
    public static ImageManager Instance;

    public Sprite square1x1;
    public Sprite transparent1x1;

    // Called by Game when the game starts
    public void Init()
    {
        Instance = this;
    }
}

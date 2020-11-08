using UnityEngine;
using UnityEngine.UI;

public class ItemSlotShadow : MonoBehaviour
{
    public static ItemSlotShadow Instance;

    public Image image;

    // Called by UIManager.Init when the game starts
    public void Init()
    {
        Instance = this;
    }

    public void Enable(Vector3 _position)
    {
        transform.position = _position;
        image.enabled = true;
    }

    public void Disable()
    {
        image.enabled = false;
    }
}

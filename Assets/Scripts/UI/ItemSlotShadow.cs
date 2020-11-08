using UnityEngine;
using UnityEngine.UI;

public class ItemSlotShadow : MonoBehaviour
{
    public static ItemSlotShadow Instance;

    public Image image;

    public void Start()
    {
        Instance = this;
    }

    public static void Enable(Vector3 _position)
    {
        Instance.transform.position = _position;
        Instance.image.enabled = true;
    }

    public static void Disable()
    {
        Instance.image.enabled = false;
    }
}

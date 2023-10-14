using UnityEngine;

public class ObjectIdentifier : MonoBehaviour
{
    private void Awake()
    {
        InputManager.OnClickStarted += IdentifyObjectClicked;
    }

    private void OnDestroy()
    {
        InputManager.OnClickStarted -= IdentifyObjectClicked;
    }

    private void IdentifyObjectClicked(RaycastHit2D hit2D)
    {
        if (hit2D.transform != null && hit2D.collider.CompareTag("Fruit"))
        {
            Debug.Log($"Object Hit");
        }
    }
}

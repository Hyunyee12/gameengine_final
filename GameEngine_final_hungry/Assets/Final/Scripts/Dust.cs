using UnityEngine;

public class DustClicker : MonoBehaviour
{
    Camera cam;
    int dustLayerMask;

    void Start()
    {
        cam = Camera.main;
        dustLayerMask = LayerMask.GetMask("Dust"); // Dust 레이어
    }

    void Update()
    {
        if (!UnityEngine.Input.GetMouseButtonDown(0)) return;

        Vector2 mousePos = cam.ScreenToWorldPoint(UnityEngine.Input.mousePosition);

        Collider2D hit = Physics2D.OverlapPoint(mousePos, dustLayerMask);

        if (hit != null)
        {
            Debug.Log("Dust removed");
            Destroy(hit.gameObject);
        }
    }
}

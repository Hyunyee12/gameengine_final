using UnityEngine;

public class BackgroundSizeCheck : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        float bgWidth = sr.bounds.size.x;
        float bgHeight = sr.bounds.size.y;

        Debug.Log($"배경 가로: {bgWidth}, 세로: {bgHeight}");
    }
}

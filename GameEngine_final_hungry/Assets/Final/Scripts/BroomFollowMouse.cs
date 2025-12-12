using UnityEngine;

public class BroomFollowMouse : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.visible = false; // 기본 커서 숨기기
    }

    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        transform.position = mouse;

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Clean");
        }
    }
}

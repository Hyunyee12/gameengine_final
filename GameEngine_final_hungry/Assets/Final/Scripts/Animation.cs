using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 100f;

    Animator anim;
    SpriteRenderer sprite;

    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float move = 0f;

        if (Input.GetKey(KeyCode.A)) move = -1f;
        if (Input.GetKey(KeyCode.D)) move = 1f;

        // 좌우 이동
        transform.position += new Vector3(move, 0, 0) * speed * Time.deltaTime;

        // 애니메이션 Speed 연동
        anim.SetFloat("Speed", Mathf.Abs(move));

        // flipX로 방향 전환
        if (move < 0) sprite.flipX = true;
        else if (move > 0) sprite.flipX = false;
    }
}

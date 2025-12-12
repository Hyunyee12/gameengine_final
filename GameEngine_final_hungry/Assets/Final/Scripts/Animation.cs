using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 20f;

    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        float move = 0f;

        if (Input.GetKey(KeyCode.A)) move = -1f;
        if (Input.GetKey(KeyCode.D)) move = 1f;

        // 물리 기반 이동 (충돌 정상 처리)
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);


        // 애니메이션
        anim.SetFloat("Speed", Mathf.Abs(move));

        // 방향 전환
        if (move < 0) sprite.flipX = true;
        else if (move > 0) sprite.flipX = false;
    }
}

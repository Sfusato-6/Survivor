using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Rigidbody2D target;

    bool IsLive = true;

    Rigidbody2D rigid;
    SpriteRenderer spriter;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (!IsLive) return;

        Vector2 dirVec = target.position - this.rigid.position;
        Vector2 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(this.rigid.position + nextVec);
        this.rigid.velocity = Vector2.zero;
    }

    void LateUpdate()
    {
        if (!IsLive) return;
        spriter.flipX = target.position.x < rigid.position.x;
    }

}

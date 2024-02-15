using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCtrl : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;

    Rigidbody2D rigid;
    SpriteRenderer spriter;
    Animator anim;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        //normalize -> Player Input 컴포넌트 상에서 되어있음
        Vector2 nextVec = inputVec * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
        
    }

    private void LateUpdate()
    {
        anim.SetFloat("Speed", inputVec.magnitude);

        if(inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;


        }

            

    }

    void OnMove(InputValue val)
    {
        inputVec = val.Get<Vector2>();
    }
}

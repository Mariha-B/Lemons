using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 7f;
    private Vector2 moveDir;
    [SerializeField] private Animator anim;
    [SerializeField] private SpriteRenderer player;

    private void Start()
    {
        GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(moveDir.x > 0f)
        {
            player.flipX = false;
        }else if(moveDir.x < 0f)
        {
            player.flipX = true;
        }
        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", moveDir.x);
        anim.SetFloat("Vertical", moveDir.y);
        anim.SetFloat("Speed", moveDir.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDir.normalized * moveSpeed * Time.deltaTime);
    }
}

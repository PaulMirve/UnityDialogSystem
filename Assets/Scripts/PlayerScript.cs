using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public bool canMove;

    Rigidbody2D rigidBody;
    Vector2 moveVelocity;

    private void Awake()
    {
        References.player = this;
    }
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (canMove)
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            moveVelocity = moveInput.normalized * speed;
        }
    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + moveVelocity * Time.fixedDeltaTime);
    }
}

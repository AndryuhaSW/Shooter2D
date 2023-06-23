using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    
    private Vector2 movement;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
        
        
        // if (movement.x != 0 || movement.y != 0)
        // {
        //     animator.SetFloat("X", movement.x);
        //     animator.SetFloat("Y", movement.y);
        //
        //     animator.SetBool("IsWalking",true);
        // }else
        // {
        //     animator.SetBool("IsWalking",false);
        // }
    }

    private void FixedUpdate()
    {
        rb.AddForce(movement * moveSpeed);
    }
}

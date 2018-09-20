using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed;
    public float JumpHeight;
    public Rigidbody Rigbod;
    public Collider PlayerCollider;
    public bool CanJump;
    
    private float vert;
    private float horiz;
    private Vector3 movement;
    private Vector3 turn;
    private Vector3 jump;

    private void Start()
    {
        movement = new Vector3(0, 0, 0);
        turn = new Vector3(0, 0, 0);
        jump = new Vector3(0, 0, 0);
        CanJump = true;
    }

    private void Update()
    {
        vert = Input.GetAxis("Vertical");
        horiz = Input.GetAxis("Horizontal");

        movement = new Vector3( 0.0f, 0.0f, vert );
        turn = new Vector3( 0.0f, horiz, 0.0f );
        
        transform.Translate(movement*Speed);
        transform.Rotate(turn*Speed);
        
    }
    private void FixedUpdate()
    {
        if( Input.GetButtonDown("Jump") && CanJump )
        {
            JumpUp();
        }
    }

    private void JumpUp()
    {
        jump = transform.position + Vector3.up * JumpHeight;
        transform.Translate(Vector3.Lerp(transform.position,jump, 1.0f/6.0f));
    }

    
}

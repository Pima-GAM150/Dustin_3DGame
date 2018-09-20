using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed;
    public float JumpHeight;
    public Rigidbody Rigbod;
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
        jump = new Vector3(0, JumpHeight*75, 0);
        CanJump = true;
    }

    private void Update()
    {
        vert = Input.GetAxis("Vertical");
        horiz = Input.GetAxis("Horizontal");

        movement = new Vector3( 0.0f, 0.0f, vert );
        turn = new Vector3( 0.0f, horiz, 0.0f );

        if (Input.GetButtonDown("Jump") && CanJump)
        {
            JumpUp();
        }

        transform.Translate(movement*Speed);
        transform.Rotate(turn*Speed);
    }
    
    void JumpUp()
    {
        Rigbod.AddForce(jump);
    }
}

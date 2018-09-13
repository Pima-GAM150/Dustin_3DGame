using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed;
    public float Turn;
    public float JumpSpeed;
    public float JumpHeight;
    public Rigidbody Rigbod;

    private float vert;
    private float horiz;
    private Vector3 movement;
    private Vector3 turn;

    private void Start()
    {
        movement = new Vector3(0, 0, 0);
        turn = new Vector3(0, 0, 0);
    }

    private void Update()
    {
        vert = Input.GetAxis("Vertical");
        horiz = Input.GetAxis("Horizontal");

        movement = new Vector3( horiz, 0.0f, vert );
       
        Rigbod.AddForce(movement * Speed * Time.deltaTime);
        if(Input.GetKeyDown("v"))
        {
            StopRolling();
        }

        if(Input.GetAxis("Jump")>0)
        {

            JumpUp();
        }
    }

    private void StopRolling()
    {
        Rigbod.velocity = Vector3.zero;
    }
    private void JumpUp()
    {
        if(transform.position.y <= transform.position.y + JumpHeight)
            Rigbod.AddForce(Vector3.up * JumpSpeed * Time.deltaTime);
    }
}

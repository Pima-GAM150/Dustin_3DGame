﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed;
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
        
        if(Input.GetButtonDown("Jump") )
        {
            JumpUp();
        }

        Rigbod.AddForce(movement * Speed);
        
    }

    private void JumpUp()
    {
        movement.y = JumpHeight;
    }
}

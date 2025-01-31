﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalMove;
    public float verticalMove;
    public CharacterController player;
    public float playerSpeed = 1.0f;
    
    // Start is called before the first frame update
    void Start(){
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update(){
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
    }
    public void FixedUpdate(){
        player.Move(new Vector3(horizontalMove,0,verticalMove));
    }
}

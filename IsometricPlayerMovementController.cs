﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricPlayerMovementController : MonoBehaviour
{

    public float movementSpeed = 1f;
    IsometricCharacterRenderer isoRenderer;
    public SpriteRenderer karl;
    public Animator trevor;

    Rigidbody2D rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        isoRenderer = GetComponentInChildren<IsometricCharacterRenderer>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 currentPos = rbody.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
        inputVector = Vector2.ClampMagnitude(inputVector, 1);
        Vector2 movement = inputVector * movementSpeed;
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
        isoRenderer.SetDirection(movement);
        rbody.MovePosition(newPos);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //gameObject.transform.localScale = new Vector2(-1, 1);
            karl.flipX = true;
            trevor.SetBool("isWalkingUp", true);
            trevor.SetBool("isWalking", true);

        }
        if (Input.GetKey(KeyCode.D))
        {
            //gameObject.transform.localScale = new Vector2(1, 1);
            karl.flipX = false;
            trevor.SetBool("isWalking", true);
            trevor.SetBool("isWalkingUp", true);
        }
    }
}

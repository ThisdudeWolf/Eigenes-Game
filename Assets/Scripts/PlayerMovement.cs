using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float jumpStrength;
    public string isGrounded;
    public float runSpeed;
   
    // Start is called before the first frame update
    void Start()
    {
        body.freezeRotation = true;
        isGrounded = "y";
        jumpStrength = 5;
        runSpeed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) == true && isGrounded == "y")
        {
            body.velocity += Vector2.up * jumpStrength;
            isGrounded = "n";
        }
        if (GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            isGrounded = "y";
        }

        //Running
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(horizontalInput, 0, 0);

        transform.Translate(direction * runSpeed * Time.deltaTime);
    }
}

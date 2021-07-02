using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private bool move;

    public Rigidbody2D rb;

    public float speed = 10f;
    public float rotationSpeed = 10f;

    public bool isGrounded;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            move = true;
        }
        if (Input.GetButtonUp("Fire1"))
        { 
            move = false;
        }
    }

    private void FixedUpdate()
    {
        if (move == true)
        {
            if (isGrounded)
            {
                rb.AddForce(transform.right * speed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
            else
            {
                rb.AddTorque(rotationSpeed * rotationSpeed * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            }
            
        }
    }

    private void OnCollisionEnter2D()
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D()
    {
        isGrounded = false;
    }
}

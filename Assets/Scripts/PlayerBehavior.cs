using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    private bool isMoveing, isRotating;
    private Vector2 mouseValue;
    private Rigidbody rb;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(2.0f * new Vector3(0, mouseValue.x, 0)); // Rotate speed = 2.0f
        }
        
        if (isMoveing)
        {
            rb.velocity = transform.forward * 5.0f; // Move speed = 5.0f
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }

    private void OnStartMoving()
    {
        isMoveing = true;
        //animator.SetBool("isRunning", true);
    }
    private void OnStopMoving()
    {
        isMoveing = false;
        //animator.SetBool("isRunning", false);
    }
    private void OnStartRotating()
    {
        isRotating = true;
    }
    private void OnStopRotating()
    {
        isRotating = false;
    }
    private void OnRotate(InputValue value)
    {
        mouseValue = value.Get<Vector2>();
        mouseValue.Normalize();
    }
    private void OnPause()
    {
        FindObjectOfType<GameManager>().PauseResume();
    }
}

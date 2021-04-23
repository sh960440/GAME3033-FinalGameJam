using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private Animator animator;
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

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collide"); 
        switch (other.tag)
        {
            case "Operator":
                gameManager.OperateNum(other.GetComponent<OperatorBehavior>().operation, other.GetComponent<OperatorBehavior>().value);
                break;
            case "Square":
                gameManager.SquareNum();
                break;
            case "SquareRoot":
                gameManager.SquareRootNum();
                break;
            default:
                break;
        }
        Destroy(other.gameObject);  
    }

    private void OnStartMoving()
    {
        isMoveing = true;
        animator.SetBool("Run", true);
    }
    private void OnStopMoving()
    {
        isMoveing = false;
        animator.SetBool("Run", false);
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

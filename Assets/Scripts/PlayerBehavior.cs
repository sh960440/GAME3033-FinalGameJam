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
    private AudioSource pickSound;

    // Start is called before the first frame update
    void Start()
    {
        pickSound = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.isPlaying) return;

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

    public void ResetPosition()
    {
        transform.position = new Vector3(0, transform.position.y, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Operator":
                gameManager.OperateNum(other.GetComponent<OperatorBehavior>().operation, other.GetComponent<OperatorBehavior>().value);
                pickSound.Play();
                break;
            case "Square":
                gameManager.SquareNum();
                pickSound.Play();
                break;
            case "SquareRoot":
                gameManager.SquareRootNum();
                pickSound.Play();
                break;
            case "DeathPlane":
                gameManager.GameOver(false);
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

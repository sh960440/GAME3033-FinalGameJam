using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private TMP_Text buffText;
    [SerializeField] private GameObject[] walls;
    [SerializeField] private Light[] lights;
    private bool isMoveing, isRotating;
    private Vector2 mouseValue;
    private Rigidbody rb;
    private GameManager gameManager;
    private AudioSource pickSound;
    private float movingSpeed = 5.0f;

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
            rb.velocity = transform.forward * movingSpeed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }

    public void ResetPlayer()
    {
        transform.position = new Vector3(0, transform.position.y, 0);

        StopAllCoroutines();
        buffText.text = " ";
        movingSpeed = 5.0f;
        transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        foreach (GameObject wall in walls)
        {
            wall.SetActive(true);
        }
        foreach (Light light in lights)
        {
            light.intensity = 0.6f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
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
            case "Chest":
                OpenChest();
                break;
            default:
                break;
        }
        pickSound.Play();
        Destroy(other.gameObject);  
    }

    public void OpenChest()
    {
        int rand = Random.Range(1, 5);
        switch (rand)
        {
            case 1:
                StartCoroutine(SpeedUpBuff());
                break;
            case 2:
                StartCoroutine(SlowDownDebuff());
                break;
            case 3:
                StartCoroutine(RemoveWallsBuff());
                break;
            case 4:
                StartCoroutine(LightOffDebuff());
                break;
        }
    }

    IEnumerator SpeedUpBuff()
    {
        buffText.text = "Buff: Speed";
        transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y, transform.localScale.z);
        movingSpeed *= 2;
        yield return new WaitForSeconds(10.0f);
        buffText.text = " ";
        transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y, transform.localScale.z);
        movingSpeed /= 2;
    }
    IEnumerator SlowDownDebuff()
    {
        buffText.text = "Debuff: Speed";
        transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y, transform.localScale.z);
        movingSpeed /= 2;
        yield return new WaitForSeconds(8.0f);
        buffText.text = " ";
        transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y, transform.localScale.z);
        movingSpeed *= 2;
    }
    IEnumerator RemoveWallsBuff()
    {
        buffText.text = "Buff: Wall";
        foreach (GameObject wall in walls)
        {
            wall.SetActive(false);
        }
        yield return new WaitForSeconds(10.0f);
        buffText.text = " ";
        foreach (GameObject wall in walls)
        {
            wall.SetActive(true);
        }
    }
    IEnumerator LightOffDebuff()
    {
        buffText.text = "Debuff: Light";
        foreach (Light light in lights)
        {
            light.intensity = 0.03f;
        }
        yield return new WaitForSeconds(8.0f);
        buffText.text = " ";
        foreach (Light light in lights)
        {
            light.intensity = 0.6f;
        }
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
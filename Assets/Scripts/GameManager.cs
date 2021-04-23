using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Other screens
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject gameoverScreen;
    [SerializeField] private TMP_Text gameOverText;

    // GameplayUi
    [SerializeField] private Text targetText;
    [SerializeField] private Text currentText;
    [SerializeField] private Text timerText;
    [SerializeField] private Text levelText;
    [SerializeField] private TMP_Text countDownText;

    public bool isPlaying = false;
    private int currentNumber;
    private int currentLevel;
    private int targetMin;
    private int targetMax;
    private float timer;
    private bool isPaused = false;
    private AudioSource matchSound;

    void Start()
    {
        matchSound = GetComponent<AudioSource>();

        Time.timeScale = 1.0f;
        currentLevel = 1;
        currentNumber = 1;

        GenerateTarget(currentLevel);
    }

    void Update()
    {
        if (isPlaying)
        {
            if (timer >= 0)
            {
                timer -= Time.deltaTime;
                timerText.text = timer.ToString("0.0");
            }
            else
            {
                GameOver(false);
            }
        }
    }

    private void GenerateTarget(int level)
    {   
        isPlaying = false;

        int center;
        switch (level)
        {
            case 1:
                center = Random.Range(50, 60);
                targetMin = center - 30;
                targetMax = center + 30;
                break;
            case 2:
                center = Random.Range(80, 100);
                targetMin = center - 25;
                targetMax = center + 25;
                break;
            case 3:
                center = Random.Range(200, 400);
                targetMin = center - 20;
                targetMax = center + 20;
                break;
            case 4:
                center = Random.Range(300, 600);
                targetMin = center - 15;
                targetMax = center + 15;
                break;
            case 5:
                center = Random.Range(500, 800);
                targetMin = center - 12;
                targetMax = center + 12;
                break;
            case 6:
                center = Random.Range(400, 700);
                targetMin = center - 10;
                targetMax = center + 10;
                break;
            case 7:
                center = Random.Range(200, 600);
                targetMin = center - 8;
                targetMax = center + 7;
                break;
            case 8:
                center = Random.Range(400, 700);
                targetMin = center - 5;
                targetMax = center + 5;
                break;
            case 9:
                center = Random.Range(700, 1200);
                targetMin = center - 3;
                targetMax = center + 2;
                break;
            case 10:
                center = Random.Range(1000, 2000);
                targetMin = center;
                targetMax = center + 1;
                break;
            case 11:
                GameOver(true);
                break;
        }

        levelText.text = "Level " + currentLevel;
        targetText.text = targetMin + " - " + targetMax;
        timer = 30.0f;

        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        countDownText.gameObject.SetActive(true);
        countDownText.text = 3.ToString();
        yield return new WaitForSeconds(1.0f);
        countDownText.text = 2.ToString();
        yield return new WaitForSeconds(1.0f);
        countDownText.text = 1.ToString();
        yield return new WaitForSeconds(1.0f);
        countDownText.gameObject.SetActive(false);

        isPlaying = true;
    }

    public void OperateNum(Operation operation, int value)
    {
        switch (operation)
        {
            case Operation.ADD:
                currentNumber += value;
                break;
            case Operation.SUBTRACT:
                currentNumber -= value;
                break;
            case Operation.MULTIPLY:
                currentNumber *= value;
                break;
            case Operation.DIVIDE:
                currentNumber /= value;
                break;
        }

        currentText.text = currentNumber.ToString();
        CheckNumber();
    }

    public void SquareNum()
    {
        currentNumber = currentNumber * currentNumber;
        currentText.text = currentNumber.ToString();
        CheckNumber();
    }

    public void SquareRootNum()
    {
        currentNumber = (int)Mathf.Sqrt(currentNumber);
        currentText.text = currentNumber.ToString();
        CheckNumber();
    }

    public void CheckNumber()
    {
        if (currentNumber <= targetMax && currentNumber >= targetMin)
        {
            matchSound.Play();
            currentNumber = 1;
            currentText.text = currentNumber.ToString();
            GenerateTarget(++currentLevel);
            FindObjectOfType<PlayerBehavior>().ResetPosition();
        }
    }

    public void GameOver(bool won)
    {
        Time.timeScale = 0.0f;
        gameOverText.text = won ? "YOU WIN" : "GAME OVER";
        gameoverScreen.SetActive(true);
    }

    public void PauseResume()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0.0f : 1.0f;
        pauseScreen.SetActive(isPaused);
    }
    
    public void Menu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

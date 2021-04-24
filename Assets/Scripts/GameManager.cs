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
                center = Random.Range(45, 55);
                targetMin = center - 30;
                targetMax = center + 30;
                break;
            case 2:
                center = Random.Range(90, 110);
                targetMin = center - 25;
                targetMax = center + 25;
                break;
            case 3:
                center = Random.Range(180, 220);
                targetMin = center - 20;
                targetMax = center + 20;
                break;
            case 4:
                center = Random.Range(360, 440);
                targetMin = center - 15;
                targetMax = center + 15;
                break;
            case 5:
                center = Random.Range(720, 880);
                targetMin = center - 10;
                targetMax = center + 10;
                break;
            case 6:
                GameOver(true);
                break;
        }

        levelText.text = "Level " + currentLevel;
        targetText.text = targetMin + " - " + targetMax;
        timer = 30.0f + currentLevel * 10.0f;

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

        if (currentNumber < 1) currentNumber = 1;
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
        if (currentNumber < 1) currentNumber = 1;
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
            FindObjectOfType<OperatorGenetor>().GenerateOperators();
            FindObjectOfType<PlayerBehavior>().ResetPlayer();
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Other screens
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject gameoverScreen;

    // GameplayUi
    [SerializeField] private Text targetText;
    [SerializeField] private Text currentText;
    [SerializeField] private Text timerText;
    [SerializeField] private Text levelText;

    private int currentNumber;
    private int currentLevel;
    private int targetMin;
    private int targetMax;

    private bool isPaused = false;

    void Start()
    {
        currentLevel = 1;
        currentNumber = 1;

        GenerateTarget(currentLevel);
    }

    private void GenerateTarget(int level)
    {   
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
                targetMin = center - 20;
                targetMax = center + 40;
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
        }

        levelText.text = currentLevel.ToString();
        targetText.text = targetMin + " - " + targetMax;
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
    }

    public void SquareNum()
    {
        currentNumber = currentNumber * currentNumber;
        currentText.text = currentNumber.ToString();
    }

    public void SquareRootNum()
    {
        currentNumber = (int)Mathf.Sqrt(currentNumber);
        currentText.text = currentNumber.ToString();
    }

    public void PauseResume()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0.0f : 1.0f;
        pauseScreen.SetActive(isPaused);
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

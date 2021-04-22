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

    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

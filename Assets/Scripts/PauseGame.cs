using UnityEngine;
using UnityEngine.InputSystem;

public class PauseGame : MonoBehaviour
{
    public GameObject pausePanel;
    private bool isPaused = false;


    private void Start()
    {
        // Make sure pause panel is hidden at start
        if (pausePanel != null)
        {
            pausePanel.SetActive(false);
        }
    }
    // This method will be called when the "Esc" key is pressed
    private void Update()
    {
        // Check if ESC key is pressed
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        if (isPaused)
        {
            // Resume the game
            Time.timeScale = 1f;
            isPaused = false;
            pausePanel.SetActive(false);
        }
        else
        {
            // Pause the game
            Time.timeScale = 0f;
            isPaused = true;
            pausePanel.SetActive(true);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
        pausePanel.SetActive(false);
    }

    public void ReturnHome()
    {
        Time.timeScale = 1f;
        isPaused = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
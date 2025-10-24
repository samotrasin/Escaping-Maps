using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    private bool isGameOver = false;


   
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            isGameOver = true;
            gameOverPanel.SetActive(true);

            // Time.timeScale = 0f; // Pause the game
        }
    }
    
    public void Restart()
    {
        // Debug.Log("Restart button clicked!"); // Add this to test
        Time.timeScale = 1; // Resume the game
        SceneManager.LoadScene("LevelOne");
    }
}

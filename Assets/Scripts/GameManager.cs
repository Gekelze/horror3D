
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public bool isGameActive;
    public GameObject startGameScreen;
    public GameObject victory;
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = false;
        startGameScreen.SetActive(true);
        gameOverScreen.SetActive(false);
        victory.SetActive(false);
    }
    public void StartGame()
    {
        startGameScreen.SetActive(false);
        isGameActive = true;
        Debug.Log("тест 1");  
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
        

    // Update is called once per frame
    public void GameOver()
    {
        isGameActive = false;
        Debug.Log("Game Over");
        gameOverScreen.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public bool IsGameActive()
    {
         return isGameActive;
    }
    public void VictoryGame()
    {
        victory.SetActive(true);
    }
    public void NextLevel()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public GameObject player;
    public GameObject panelGameOver;
    public Button restartButton;
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        if (player.transform.position.y < -10)
        {
            GameOver();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        panelGameOver.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isGameActive = true;
        panelGameOver.gameObject.SetActive(false);
    }
}

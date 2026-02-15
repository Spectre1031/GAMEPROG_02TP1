using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameObject gameOverMessage;
    public float timeRemaining = 60f;

    void Start()
    {
        // 1. Hide the Game Over text immediately when the game starts
        gameOverMessage.SetActive(false);

        // 2. Ensure the game runs at normal speed
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.CeilToInt(timeRemaining).ToString();
        }
        else
        {
            timerText.text = "Time: 0";

            // Turn ON the Game Over text only when time is up
            gameOverMessage.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
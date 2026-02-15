using UnityEngine;

public class VictoryTrigger : MonoBehaviour
{
    // This creates an empty box in Unity where we will plug in your Victory Text
    public GameObject victoryMessage;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object entering the door is specifically the Player
        if (other.gameObject.name == "Player")
        {
            // 1. Turn ON the Victory text
            victoryMessage.SetActive(true);

            // 2. Freeze the game so the timer stops and the player can't move
            Time.timeScale = 0f;
        }
    }
}
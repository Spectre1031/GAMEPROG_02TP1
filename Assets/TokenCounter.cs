using UnityEngine;
using TMPro; // This is needed to talk to your UI text

public class TokenCounter : MonoBehaviour
{
    public TextMeshProUGUI countText;
    private int score = 0;

    void Start()
    {
        UpdateText();
    }

    // Call this whenever a token is picked up
    public void AddToken()
    {
        score++;
        UpdateText();
    }

    void UpdateText()
    {
        countText.text = "Tokens: " + score;
    }
}
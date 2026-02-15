using UnityEngine;

public class TokenTrigger : MonoBehaviour
{
    // 1. This creates an empty box in the Inspector for your sound file
    public AudioClip tokenSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            // 2. Play the sound file right where the token is standing
            if (tokenSound != null)
            {
                AudioSource.PlayClipAtPoint(tokenSound, transform.position);
            }

            // Add the point and destroy the token
            FindObjectOfType<TokenCounter>().AddToken();
            Destroy(gameObject);
        }
    }
}
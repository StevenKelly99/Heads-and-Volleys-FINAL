using UnityEngine;
using UnityEngine.SceneManagement;

public class balleasyController : MonoBehaviour
{
    public GameObject player;

    // Initial position of the ball
    private Vector3 initialPosition;
    private string gameOverScene = "GameOverEasy";
    private int score = 0;

    void Start()
    {
        // Save the initial position of the ball
        initialPosition = transform.position;
    }

    void Update()
    {
        // Checks if the ball is touching the ground
        if (transform.position.y < 0)
        {
            // Trigger game over and show UI
            Destroy(gameObject);
            SceneManager.LoadScene(gameOverScene);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Checks if ball is colliding with player
        if (collision.gameObject.tag == "Player")
        {
            // Increase score
            ScoreManager.scoreCounter += 1;
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Ground")
        {
          
        }
    }
}
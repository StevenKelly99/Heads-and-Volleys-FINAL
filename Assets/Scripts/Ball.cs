using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public GameObject player;

    private Vector3 initialPosition;

    private string gameOverScene = "GameOverHard";

    private int score = 0;

    void Start()
    {
        // Saves the initial position of the ball
        initialPosition = transform.position;
    }

    void Update()
    {
        // Checks if ball touches ground
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(gameOverScene);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Checks if the ball collides with player
        if (collision.gameObject.tag == "Player")
        {
            // Increase the score
            ScoreManager.scoreCounter += 1;

            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Ground")
        {
          
        }
    }
}
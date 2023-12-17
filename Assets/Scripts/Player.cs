using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    // (from older code was supposed to allow player to jump)
    public float hitForceMultiplier = 20f;
    public bool canJump = true;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();

            // Modifies vertical velocity of the ball
            Vector3 newVelocity = new Vector3(ballRb.velocity.x, hitForceMultiplier, ballRb.velocity.z);

            ballRb.velocity = newVelocity;

            // Destroys the ball
            StartCoroutine(DestroyBallAfterDelay(collision.gameObject));
        }
    }

    // Method for collision of player
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody playerRb = GetComponent<Rigidbody>();
            playerRb.velocity = Vector3.zero;
            playerRb.angularVelocity = Vector3.zero;
            playerRb.constraints = RigidbodyConstraints.FreezeRotation; // Freezes rotation
        }
    }


    void Update()
    {
       
    }


    IEnumerator DestroyBallAfterDelay(GameObject ball)
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(ball);
    }

}

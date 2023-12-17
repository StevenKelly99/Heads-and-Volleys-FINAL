using System.Collections;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnInterval = 2f;
    public float ballSpeed = 5f;

    void Start()
    {
        //Starts spawning the balls
        StartCoroutine(SpawnBalls());
    }


    // Method to spawn balls
    IEnumerator SpawnBalls()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            // Spawns ball at specific location
            GameObject newBall = Instantiate(ballPrefab, new Vector3(-0.28f, 15f, -13.01f), Quaternion.identity);
            Rigidbody rb = newBall.GetComponent<Rigidbody>();

            // Sets velocity with random horizontal direction but fixed downward direction
            rb.velocity = new Vector3(Random.Range(-1f, 1f), -1f, 0f).normalized * ballSpeed;
        }
    }
}

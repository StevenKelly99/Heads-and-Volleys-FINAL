using System.Collections;
using UnityEngine;

public class BallSpawnerEasy : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnInterval = 2f;
    public float ballSpeed = 5f;

    void Start()
    {
        StartCoroutine(SpawnBalls());
    }

    IEnumerator SpawnBalls()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            GameObject newBall = Instantiate(ballPrefab, new Vector3(-0.7681561f, 15f, 0.2495033f), Quaternion.identity);
            Rigidbody rb = newBall.GetComponent<Rigidbody>();

            rb.velocity = new Vector3(Random.Range(-1f, 1f), -1f, 0f).normalized * ballSpeed;
        }
    }
}

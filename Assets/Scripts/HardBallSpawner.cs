using System.Collections;
using UnityEngine;

public class HardBallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnInterval = 1f;
    public float ballSpeed = 4f; 

    void Start()
    {
        StartCoroutine(SpawnBalls());
    }

    IEnumerator SpawnBalls()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            GameObject newBall = Instantiate(ballPrefab, new Vector3(-0.28f, 15f, -13.01f), Quaternion.identity);
            Rigidbody rb = newBall.GetComponent<Rigidbody>();

            rb.velocity = new Vector3(Random.Range(-1f, 1f), -1f, 0f).normalized * ballSpeed;
        }
    }
}

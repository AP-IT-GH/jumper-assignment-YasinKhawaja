using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCourse : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject obstacleOpposite;
    public GameObject obstacleSpawner;
    public GameObject obstacleSpawner2;
    private float waitTime = 0f;
    private bool spawn = true;

    private void OnEnable()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (spawn)
        {
            waitTime = Random.Range(2f, 5f);
            yield return new WaitForSeconds(waitTime);
            SpawnObstacle();
            waitTime = Random.Range(2f, 5f);
            yield return new WaitForSeconds(waitTime);
            SpawnObstacleOpposite();
        }
    }

    private void SpawnObstacle()
    {
        GameObject newObstacle = Instantiate(obstacle.gameObject);
        newObstacle.transform.SetParent(obstacleSpawner.transform);
        newObstacle.transform.localPosition = new Vector3(1.5f, 0.5f, -8);
    }

    private void SpawnObstacleOpposite()
    {
        GameObject newObstacle = Instantiate(obstacleOpposite.gameObject);
        newObstacle.transform.SetParent(obstacleSpawner2.transform);
        newObstacle.transform.localPosition = new Vector3(1.5f, 0.5f, -8);
    }

    public void ClearEnvironment()
    {
        spawn = false;
        foreach (Transform obstacle in obstacleSpawner.transform)
        {
            GameObject.Destroy(obstacle.gameObject);
        }
        foreach (Transform obstacle in obstacleSpawner2.transform)
        {
            GameObject.Destroy(obstacle.gameObject);
        }
        spawn = true;
    }
}

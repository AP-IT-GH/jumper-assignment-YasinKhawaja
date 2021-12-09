using System.Collections;
using UnityEngine;

public class ObstacleCourse : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject obstacleOpposite;
    public GameObject obstacleSpawner1;
    public GameObject obstacleSpawner2;

    private bool spawn = true;
    [SerializeField]
    private bool secondSpawner = false;

    private void OnEnable()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        while (spawn)
        {
            var waitTime = Random.Range(10f, 13f);
            yield return new WaitForSeconds(waitTime);
            SpawnObstacle();
            if (secondSpawner)
            {
                waitTime = Random.Range(8f, 10f);
                yield return new WaitForSeconds(waitTime);
                SpawnObstacleOpposite();
            }
        }
    }

    private void SpawnObstacle()
    {
        GameObject newObstacle = Instantiate(obstacle.gameObject);
        newObstacle.transform.SetParent(obstacleSpawner1.transform);
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
        foreach (Transform obstacle in obstacleSpawner1.transform)
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

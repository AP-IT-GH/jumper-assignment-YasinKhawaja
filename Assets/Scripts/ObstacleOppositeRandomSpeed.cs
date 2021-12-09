using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleOppositeRandomSpeed : MonoBehaviour
{
    [SerializeField]
    private float _obstacleSpeed = 0f;
    private JumpAgent agent;

    void Start()
    {
        agent = GameObject.Find("Agent").GetComponent<JumpAgent>();
        _obstacleSpeed = Random.Range(3, 6);
    }

    void Update()
    {
        transform.localPosition += new Vector3(0, 0, _obstacleSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Border"))
        {
            agent.AddReward(1f);
            Destroy(this.gameObject);
        }
    }
}

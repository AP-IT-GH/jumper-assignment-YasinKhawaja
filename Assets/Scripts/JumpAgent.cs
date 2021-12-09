using TMPro;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using UnityEngine;

public class JumpAgent : Agent
{
    [SerializeField]
    private float jumpSpeed = 3f;
    [SerializeField]
    private TextMeshPro score;
    private ObstacleCourse obstacleCourse;
    private Rigidbody m_Rigidbody;
    private bool jump = true;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        obstacleCourse = GetComponentInParent<ObstacleCourse>();
    }

    void Update()
    {
        score.text = GetCumulativeReward().ToString("f4");
    }

    public override void OnEpisodeBegin()
    {
        obstacleCourse.ClearEnvironment();
        transform.localPosition = new Vector3(0, 0.75f, 0);
        transform.localRotation = Quaternion.Euler(0, 90, 0f);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        var action = actions.DiscreteActions;
        if (action[0] == 1)
        {
            AddReward(-0.01f);
            Jump();
        }
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var jump = 0;
        if (Input.GetKey(KeyCode.Space))
        {
            jump = 1;
        }
        var discreteActionsOut = actionsOut.DiscreteActions;
        discreteActionsOut[0] = jump;
    }

    private void Jump()
    {
        if (this.jump)
        {
            m_Rigidbody.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.VelocityChange);
            this.jump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Plane"))
        {
            this.jump = true;
        }
        else if (collision.transform.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            AddReward(-1f);
        }
    }
}

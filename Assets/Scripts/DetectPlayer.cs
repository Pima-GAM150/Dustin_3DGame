using UnityEngine;
using UnityEngine.AI;

public class DetectPlayer : MonoBehaviour
{

    public GameObject Player;
    public NavMeshAgent NavMesh;

    private float IniSpeed, AdjSpeed;
    private void Start()
    {
        IniSpeed = NavMesh.speed;
        AdjSpeed = NavMesh.speed * 20;
    }

    private void Update()
    {
        if(NavMesh.isActiveAndEnabled)
        {
            NavMesh.SetDestination(Player.transform.position);

            if (Vector3.Distance(Player.transform.position, transform.position) >= 10.0f)
            {
                NavMesh.speed = AdjSpeed;
            }
            else
            {
                NavMesh.speed = IniSpeed;
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!NavMesh.isActiveAndEnabled)
        {
            NavMesh.enabled = true;
        }
    }
}

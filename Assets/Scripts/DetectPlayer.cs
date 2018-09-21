using UnityEngine;
using UnityEngine.AI;

public class DetectPlayer : MonoBehaviour
{

    public GameObject Player;
    public float VisionRadius;
    public NavMeshAgent NavMesh;
    public Vector3 Offset;

    private bool PlayerDetected;
    private RaycastHit hit;

    private void FixedUpdate()
    {
        if (NavMesh.isActiveAndEnabled)
        {
            if (Physics.Raycast(transform.position, Player.transform.position, out hit) && hit.distance <= VisionRadius )
            {
                NavMesh.SetDestination(Player.transform.position);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!NavMesh.isActiveAndEnabled)
            NavMesh.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (NavMesh.isActiveAndEnabled)
        {
            NavMesh.destination = Player.transform.position - Offset;
        }
    }
}

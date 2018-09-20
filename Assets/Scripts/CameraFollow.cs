using UnityEngine;


public class CameraFollow : MonoBehaviour
{

    public Transform Target;
    public float SmoothSpeed;
    public Vector3 TransOffset;

    private Vector3 desiredPosition;
    private Vector3 smoothedPosition;
    
    private void FixedUpdate()
    {
    }

}
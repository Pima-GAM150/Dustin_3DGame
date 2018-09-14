using UnityEngine;


public class CameraFollow : MonoBehaviour
{

    public Transform Target;
    public float SmoothSpeed;
    public Vector3 Offset;

    private Vector3 desiredPosition;
    private Vector3 smoothedPosition;
    //private Vector3 mouse;
/*
    private void Start()
    {
        mouse = new Vector3();
    }
*/
    private void FixedUpdate()
    {
        //mouse.x += Input.GetAxis("Mouse X");
        //mouse.y += Input.GetAxis("Mouse Y");

        desiredPosition = Target.position + Offset;
        smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed);

        transform.position = smoothedPosition;


        transform.LookAt(Target);
    }

}

using UnityEngine;

public class JumpLimiter : MonoBehaviour {

    public int JumpHeightMax;
    public PlayerController ctrl;

    RaycastHit hit;
    

	void Start ()
    {
		
	}
	
	void Update ()
    {
        Physics.Raycast(transform.position, Vector3.down, out hit);

        if(hit.distance >= JumpHeightMax)
        {
            ctrl.CanJump = false;
            ctrl.Rigbod.AddForce(Vector3.down * 6);
        }
        else
        {
            ctrl.CanJump = true;
        }
	}
}

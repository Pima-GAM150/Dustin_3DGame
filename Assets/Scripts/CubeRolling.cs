using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRolling : MonoBehaviour {

    public float Speed;
    private float vert;

	void Update () {

        vert = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(vert * Speed, 0.0f, 0.0f));
    }
}

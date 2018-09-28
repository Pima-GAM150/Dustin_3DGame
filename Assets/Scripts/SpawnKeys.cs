using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKeys : MonoBehaviour {

    public GameObject Key;

    Random rnd;
    Vector3 pos;
    Quaternion rot;

	void Start ()
    {
        rot = Quaternion.identity;

		for (int i = 0; i < 3; i++)
        {
            pos = new Vector3(Random.Range(120, 890), Random.Range(120, 890), 80);

            Instantiate(Key, pos, rot);
        }
	}
	
}

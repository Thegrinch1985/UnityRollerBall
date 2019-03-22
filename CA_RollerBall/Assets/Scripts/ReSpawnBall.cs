using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawnBall : MonoBehaviour
{
     int maxFall = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y <= maxFall)
        {
            transform.position = new Vector3(0f,.99f,0f);

        }
	}
}

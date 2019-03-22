using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
   public GameObject Ball;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - Ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
              transform.position = Ball.transform.position + offset;
        
    }
}

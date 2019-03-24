﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{ public float rotationSpeed = 100f;

    private Rigidbody rb;
  

    private bool isFalling = false;

    public float damp = 0.7f;

    public static int count;
    public Text countText;
    public Text winText;


    public string playerName = "A";

    private static  GameObject go;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text ="";

    }

    // Update is called once per frame
    void Update()
    {     if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movementSpeed, rb.velocity.y);
        }
     
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (Input.GetKeyDown("space") && isFalling == false)
        {
            Vector3 jump = new Vector3(0.0f, 200.0f, 0.0f);
            rb.AddForce(jump);
        }
        isFalling = true;
        
    }
    

    void OnCollisionStay()
    {
        isFalling = false;
    }

    void OnCollisionEnter()
    {
        rb.velocity *= damp;
    }
       void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count +1;
            setCountText();

        }
    }
      void setCountText (){
    countText.text = "Count: " + count.ToString ();
    if(count == 12){

       win();
    }
    }
    void win(){

       SceneManager.LoadScene("Win");
    }
  
}

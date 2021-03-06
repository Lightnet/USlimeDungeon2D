﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rd2d;
    

	// Use this for initialization
	void Start () {
        rd2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	//void Update () {	
	//}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rd2d.AddForce(movement * speed);
    }
}

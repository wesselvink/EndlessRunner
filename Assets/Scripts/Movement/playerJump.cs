using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJump : MonoBehaviour {
	public AudioSource Jump;
	public bool onGround;
	private Rigidbody2D rb;
	public float speed = 10f;


	void Start () 
	{
		onGround = true;
		rb = GetComponent<Rigidbody2D>();
	}


	void FixedUpdate () 
	{
		if (onGround == true) 
		{
			if (Input.GetButtonDown ("Jump")) 
			{
				rb.velocity = new Vector2 (0f, 5f);
				transform.Rotate(Vector3.up, speed * Time.deltaTime);
				onGround = false;
				Jump.Play ();
			}

		}


	}
	void OnCollisionEnter2D(Collision2D other)
	{  
		if ( GameObject.FindGameObjectWithTag ("Ground")) {
			onGround = true;	
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour {

	public Text scoreText;
	private int collectablesInScene;
	public int collectablesCollected = 0;

	void Start () {


	}

	void Update(){
		scoreText.text = "score: " + collectablesCollected;

	}


	 void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag =="Collectable")
		{
			collectablesCollected++;
			AudioSource Pickup = GetComponent<AudioSource> ();
			Pickup.Play ();
			Destroy (other.gameObject);


		}
	}
}
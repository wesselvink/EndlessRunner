using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestroyer : MonoBehaviour {

	public GameObject groundDestructionPoint;


	void Start () 
	{
		groundDestructionPoint = GameObject.Find ("groundDestructionPoint");
	}
	

	void Update () {
		if (transform.position.x < groundDestructionPoint.transform.position.x) 
		{
			Destroy (gameObject);
		}
	}
}

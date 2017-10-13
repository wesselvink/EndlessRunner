using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour {

	public GameObject theGround;
	public Transform generationPoint;
	public float distanceBetween;

	private float groundWidth;

	public float distanceBetweenMin;
	public float distanceBwetweenMax;

	private int groundSelector;

	public GameObject[] theGrounds;


	void Start () {
		groundWidth = theGround.GetComponent <BoxCollider2D>().size.x;
	}
	

	void Update () {
		if (transform.position.x < generationPoint.position.x) {
			distanceBetween = Random.Range (distanceBetweenMin, distanceBwetweenMax);

			transform.position = new Vector3 (transform.position.x + groundWidth + distanceBetween, transform.position.y, transform.position.z);

			groundSelector = Random.Range (0, theGrounds.Length);

			Instantiate (/*theGround,*/theGrounds[groundSelector], transform.position, transform.rotation);
		
		}
	}
}

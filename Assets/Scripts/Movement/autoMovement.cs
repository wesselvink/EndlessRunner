using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class autoMovement: MonoBehaviour {

	public int maxY;


	public Transform player;


	void Update () 
	{
		transform.position = new Vector3 (player.position.x + 0.1f, player.position.y, player.position.z); 

		if (transform.position.y <= maxY) {
			SceneManager.LoadScene ("LoseScreen");
		}

	}
}
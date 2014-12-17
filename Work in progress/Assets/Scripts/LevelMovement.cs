using UnityEngine;
using System.Collections;

public class LevelMovement : MonoBehaviour {

	public float moveSpeed;
	private float stopPosition = 83.9f;  // put value for stop level here


	void Start () 
	{
		LevelManager.inGame = true;
	}

	void Update () 
	{
		if (LevelManager.inGame) 
		{
			transform.Translate (-Vector2.right * moveSpeed * Time.deltaTime);
		}
		
		if(this.transform.position.x < -stopPosition)
		{
			GetComponent<LevelMovement>().enabled = false;
		}
	}
}

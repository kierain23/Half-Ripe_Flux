using UnityEngine;
using System.Collections;

public class LevelMovement : MonoBehaviour {

	public float moveSpeed;


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
		
		if(this.transform.position.x < -86f)// put value for stop level here
		{
			GetComponent<LevelMovement>().enabled = false;
		}
	}
}

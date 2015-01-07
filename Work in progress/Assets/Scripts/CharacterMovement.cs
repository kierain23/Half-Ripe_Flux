using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	public float moveSpeed = 2f;
	float verticalAxis;
	
	void Update () 
	{
		verticalAxis = Input.GetAxis ("Vertical");
	}

	void FixedUpdate () 
	{
		rigidbody2D.velocity = new Vector2 (0, verticalAxis * moveSpeed);

	}
}

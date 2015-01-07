using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	public float moveSpeed = 2f;
	float verticalAxis;
	
	void FixedUpdate () 
	{
		verticalAxis = Input.GetAxis ("Vertical");
		rigidbody2D.velocity = new Vector2 (0, verticalAxis * moveSpeed);
		transform.position = new Vector3 (-4.07f, this.transform.position.y, 0f);

	}
}

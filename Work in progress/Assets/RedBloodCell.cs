using UnityEngine;
using System.Collections;

public class RedBloodCell : MonoBehaviour {

	float moveSpeed;
	public float minSpeed = 1f, maxSpeed = 3f;
	
	void Start()
	{
		moveSpeed = Random.Range (minSpeed, maxSpeed);
		
		float randomY = Random.Range (-1f, 2f);
		rigidbody2D.AddForce(new Vector2(-moveSpeed, randomY));
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rigidbody2D.velocity = rigidbody2D.velocity.normalized * moveSpeed;
		
		if(this.transform.position.x < -9f)
		{
			Destroy(gameObject);
		}
	}

}

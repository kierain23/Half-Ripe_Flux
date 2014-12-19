using UnityEngine;
using System.Collections;

public class Antibody : MonoBehaviour {

	float moveSpeed;
	public float minSpeed = 1f, maxSpeed = 3f;
	public CircleCollider2D shieldCollider;
	public int clickCount = 3;
	
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
		
		if(this.transform.position.x > 12f)
		{
			Destroy(gameObject);
		}
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.transform.collider2D.name == "Player")
		{
			Destroy(gameObject);
		}
	}
	

	void Update() 
	{
		
	}
	
	public void RemoveShield()
	{
		clickCount --;
		if(clickCount <= 0)
		{
			shieldCollider.enabled = false;
			transform.GetChild(1).transform.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}

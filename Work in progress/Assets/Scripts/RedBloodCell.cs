using UnityEngine;
using System.Collections;

public class RedBloodCell : MonoBehaviour
{

	float moveSpeed;
	public float minSpeed = 0.3f, maxSpeed = 1f;
	public RedBloodCellSpawner spawnerScript;
	
	void Awake()
	{
		moveSpeed = Random.Range (minSpeed, maxSpeed);
		
		float randomY = Random.Range (-1f, 2f);
		rigidbody2D.AddForce(new Vector2(-moveSpeed, randomY));
		spawnerScript = GameObject.FindGameObjectWithTag("RedCellSpawner").GetComponent<RedBloodCellSpawner>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rigidbody2D.velocity = rigidbody2D.velocity.normalized * moveSpeed;
		
		if(this.transform.position.x <  -9f)
		{
			spawnerScript.redBloodCount--;
			Destroy(gameObject);
		}
		
		if(this.transform.position.x > 12f)
		{
			spawnerScript.redBloodCount--;
			Destroy(gameObject);
			
		}
	}

}

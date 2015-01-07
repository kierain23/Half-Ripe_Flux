using UnityEngine;
using System.Collections;

public class BulletSpeed : MonoBehaviour
{

	public float moveSpeed = 2;
	public float bulletLifetime = 2f;
	public float spawnTimer;
	private float spawnTime = 4f;
	
	
	void Start ()
	{
		rigidbody2D.AddForce(new Vector2(moveSpeed, 0));
	}
	
	
	void Update ()
	{
		spawnTimer += Time.deltaTime;
	
		if(spawnTimer >= spawnTime)
		{
			Object.Destroy(gameObject);
		}	
	}
}

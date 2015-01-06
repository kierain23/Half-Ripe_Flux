using UnityEngine;
using System.Collections;

public class BulletForce : MonoBehaviour
{
	public float speed = 1f;
	
	
	void Update()
	{
		transform.Translate( Vector2.forward * speed, Space.Self );
	}
}
using UnityEngine;
using System.Collections;

public class CollectAntibodies : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Player")
		{
			Destroy(gameObject);
		}
	}
}

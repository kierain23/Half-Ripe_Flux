using UnityEngine;
using System.Collections;

public class KillSpawners : MonoBehaviour
{

	public float lifetime = 60f;
	
	void  Awake ()
	{
		Destroy(gameObject, lifetime);
	}
}
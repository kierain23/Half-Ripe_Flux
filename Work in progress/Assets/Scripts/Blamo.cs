using UnityEngine;
using System.Collections;

public class Blamo : MonoBehaviour
{
	public float ammoCount;
	public float maxAmmo;
	public GameObject bulletprefab;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			FireAntibody();
		}
	}
	
	void FireAntibody()
	{
		Transform spawn = transform.Find( "spawn" );
	}
}

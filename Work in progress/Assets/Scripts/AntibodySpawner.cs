using UnityEngine;
using System.Collections;

public class AntibodySpawner : MonoBehaviour
{

	float spawnTimer;
	float spawnTime = 1f;
	public float minTime = 2f, maxTime = 5f;
	public GameObject antibody;

	
	void Update () 
	{
		spawnTimer += Time.deltaTime;
		if(spawnTimer >= spawnTime)
		{
			spawnTimer = 0;
			spawnTime = (int)Random.Range (minTime, maxTime);
			SpawnAntibody();
		}
	}
	
	void SpawnAntibody()
	{
		GameObject antiBodyCopy;
		float randomY = this.transform.position.y + Random.Range (-3f, 3f);
		Vector3 randomPosition = new Vector3(this.transform.position.x, randomY, 0); 
		antiBodyCopy = (GameObject)Instantiate(antibody, randomPosition, this.transform.rotation);
	}
}

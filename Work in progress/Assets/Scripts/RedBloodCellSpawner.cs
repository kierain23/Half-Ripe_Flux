using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RedBloodCellSpawner : MonoBehaviour
{

    float spawnTimer;
	float spawnTime = 2f;
	public int redBloodCount;
	public int maxBloodCells;
	public float minTime = 3f, maxTime = 8f;
	public GameObject RedBloodCell;
	
	
	// Update is called once per frame
	void Update () 
	{
		spawnTimer += Time.deltaTime;
		if(spawnTimer >= spawnTime && redBloodCount < maxBloodCells)
		{
			spawnTimer = 0;
			spawnTime = (int)Random.Range (minTime, maxTime);
			redBloodCount++;
			SpawnRedBloodCell();
		}

		
	}
	
	void SpawnRedBloodCell()
	{
		GameObject RedBloodCellCopy;
		float randomY = this.transform.position.y + Random.Range (-3f, 3f);
		Vector3 randomPosition = new Vector3(this.transform.position.x, randomY, 0); 
		RedBloodCellCopy = (GameObject)Instantiate (RedBloodCell, randomPosition, this.transform.rotation);
	}
}

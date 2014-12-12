using UnityEngine;
using System.Collections;

public class RedBloodCellSpawner : MonoBehaviour {

    float spawnTimer;
	float spawnTime = 1f;
	public float minTime = 1f, maxTime = 4f;
	public GameObject RedBloodCell;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		spawnTimer += Time.deltaTime;
		if(spawnTimer >= spawnTime)
		{
			spawnTimer = 0;
			spawnTime = (int)Random.Range (minTime, maxTime);
			SpawnRedBloodCell();
		}
	}
	
	void SpawnRedBloodCell()
	{
		Debug.Log ("SPAWNED!");
		GameObject RedBloodCellCopy;
		float randomY = this.transform.position.y + Random.Range (-3f, 3f);
		Vector3 randomPosition = new Vector3(this.transform.position.x, randomY, 0); 
		RedBloodCellCopy = (GameObject)Instantiate (RedBloodCell, randomPosition, this.transform.rotation);
		
	}
}

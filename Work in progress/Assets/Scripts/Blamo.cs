using UnityEngine;
using System.Collections;

public class Blamo : MonoBehaviour
{
	public GameObject bulletPrefab;
	Vector3 touchposition = Vector3.zero;
	RaycastHit2D hit;
	public Transform bulletSpawn;
	public float fireRate = 2f;
	private float nextFire = 0f;
	public float bulletLifetime = 2f;
	public Transform levelStop;
	
	void Update () 
	{
		FireAntibody();
	}
	
	void FireAntibody()
	{
		if(Input.GetMouseButtonDown(0)  && Time.time > nextFire && Time.timeScale == 1)
		{
			nextFire = Time.time + fireRate;
		
			float mousex = (Input.mousePosition.x);
			float mousey = (Input.mousePosition.y);
			Vector3 mouseposition = Camera.main.ScreenToWorldPoint(new Vector3 (mousex,mousey,0));
			Vector3 shootTo = new Vector3(mouseposition.x, mouseposition.y, 20);
			print (mouseposition);
			Debug.DrawLine(mouseposition, shootTo);
			RaycastHit2D hit2 = Physics2D.Linecast(mouseposition, shootTo);
			if(hit2 != false)
			{
				if(hit2.collider.gameObject.name.Contains("Player"))
				{
					if(levelStop.transform.position.x <= -83.9f)
					{
						Debug.Log (levelStop.transform.position.x);
						Instantiate(bulletPrefab, bulletSpawn.position, this.transform.rotation);
					}
				}
			}	
		}
	}
}

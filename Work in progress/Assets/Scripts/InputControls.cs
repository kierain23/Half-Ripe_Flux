using UnityEngine;
using System.Collections;

public class InputControls : MonoBehaviour {

	void Update () 
	{
		TapAntibodyShield();
	}
	
	void TapAntibodyShield()
	{
		if(Input.GetMouseButtonDown(0))
		{
			float mousex = (Input.mousePosition.x);
			float mousey = (Input.mousePosition.y);
			Vector3 mouseposition = Camera.main.ScreenToWorldPoint(new Vector3 (mousex,mousey,0));
			Vector3 shootTo = new Vector3(mouseposition.x, mouseposition.y, 20);
			print (mouseposition);
			Debug.DrawLine(mouseposition, shootTo);
			RaycastHit2D hit = Physics2D.Linecast(mouseposition, shootTo);
			if(hit.collider.gameObject.name == "AntibodyWithShield")
			{
				Antibody antibody = hit.collider.gameObject.GetComponent<Antibody>();
				antibody.RemoveShield();
			}	
		}
		
		if(Input.touchCount == 1)
		{
			
			Vector3 touchposition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector3 shootTo = new Vector3(touchposition.x, touchposition.y, 20);
			print (touchposition);
			Debug.DrawLine(touchposition, shootTo);
			RaycastHit2D hit = Physics2D.Linecast(touchposition, shootTo);
			if(hit.collider.gameObject.name == "AntibodyWithShield")
			{
				Antibody antibody = hit.collider.gameObject.GetComponent<Antibody>();
				antibody.RemoveShield();
			}	
		}
	}
}

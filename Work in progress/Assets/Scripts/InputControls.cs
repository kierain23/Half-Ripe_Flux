using UnityEngine;
using System.Collections;

public class InputControls : MonoBehaviour {

	Vector3 touchposition = Vector3.zero;
	RaycastHit2D hit;

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
			RaycastHit2D hit2 = Physics2D.Linecast(mouseposition, shootTo);
			if(hit2 != null)
			{
				if(hit2.collider.gameObject.name.Contains("AntibodyWithShield"))
				{
					Antibody antibody = hit2.collider.gameObject.GetComponent<Antibody>();
					antibody.RemoveShield();
				}	
			}
		}
		
		if(Input.touchCount == 1)
		{
			touchposition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			Vector3 shootTo = new Vector3(touchposition.x, touchposition.y, 20);
			print (touchposition);
			Debug.DrawLine(touchposition, shootTo);
			hit = Physics2D.Linecast(touchposition, shootTo);
			if(hit!=null)
			{
				if(hit.collider.gameObject.name.Contains("AntibodyWithShield"))
				{
					Antibody antibody = hit.collider.gameObject.GetComponent<Antibody>();
					antibody.RemoveShield();
				}	
			}
		}
	}
	
	void OnGUI()
	{
//		GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 400, 400), "Pos: " +touchposition);
//		if(hit)
//		GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 400, 400), "Hit: " +hit.collider.gameObject.name);
	}
}

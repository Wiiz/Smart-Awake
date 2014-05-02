using UnityEngine;
using System.Collections;

public class CheckLetters : MonoBehaviour
{
	void OnGUI () 
	{ 
		GUI.depth = 2;
		bool isHit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if(Physics.Raycast(ray,out hit))
		{
			if(Input.GetMouseButtonDown(0))
			{
				isHit = false;
				Destroy(hit.collider.gameObject);
			}
		}
	}

	void Update()
	{

	}
}
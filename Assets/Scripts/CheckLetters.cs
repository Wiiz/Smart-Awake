using UnityEngine;
using System.Collections;
using System;


public class CheckLetters : MonoBehaviour
{

	bool isHit;
	GameObject currentGo;
	
	void OnGUI () 
	{ 
		GUI.depth = 2;
		isHit = false;
	}

	void Update()
	{
		Ray rayMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitMouse;
		int missed = 0;
		char currentLetter = '\0';

		if(Input.GetMouseButtonDown(0))
		{
			if(Physics.Raycast(rayMouse, out hitMouse) && !isHit)
			{
				currentLetter = onHit (hitMouse);
				isHit = true;
				
			} else {
				missed++;
				isHit = false;
			}
			isHit = false;
		}
	}

	void destructCurrentGo()
	{
		Destroy(currentGo);
	}

	char onHit (RaycastHit hit)
	{
		if (isHit) 
		{
			currentGo = hit.collider.gameObject;
			char currentLetter = rayLetter (currentGo);

			SoundEffect.Instance.MakeBoopSound (); //making some noise
			CloudEffect.Instance.Explosion (hit.point); //making xploding
			Invoke("destructCurrentGo", 1);
			 //destroy object
			return(currentLetter);
		} 
		else 
		{
			return '0';                                                        
		}
	}



	char rayLetter (GameObject go)
	{
		// name of clouds = CloudX, CloudA, etc.. 
		return (go.name[5]);
	}


}
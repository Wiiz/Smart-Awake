using UnityEngine;
using System.Collections;
using System;


public class CheckLetters : MonoBehaviour
{

	public bool isHit;
	public GameObject currentGo;
	public string currentWord;



	void OnGUI () 
	{ 
		GUI.depth = 2;

	}

	void Update()
	{
		isHit = false;
		Ray rayMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitMouse;
		int missed = 0;
		char currentLetter = '\0';

		if(Input.GetMouseButtonDown(0))
		{
			if(Physics.Raycast(rayMouse, out hitMouse) && !isHit)
			{
				isHit = true;
				currentLetter = onHit (hitMouse);

				
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
			SendMessage("renderLetter", currentLetter);
			Debug.Log(currentLetter);
			CloudEffect.Instance.Explosion (hit.point); //making xploding
			destructCurrentGo();
			Debug.Log(this.currentWord);
			 //destroy object
			return(currentLetter);
		} 
		else 
		{
			return '0';                                                        
		}


	}
	
	void setCurrentWordSharp(string word)
	{
				this.currentWord = word;
	}


	char rayLetter (GameObject go)
	{
		char letter = go.name [5];

		// name of clouds = CloudX, CloudA, etc.. 
		return (letter);
	}


}
using UnityEngine;
using System.Collections;
using System;


public class CheckLetters : MonoBehaviour
{
	void OnGUI () 
	{ 
		GUI.depth = 2;
		bool isHit = false;
		Ray rayMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitMouse;
		int missed = 0;
		if(Input.GetMouseButtonDown(0))
		{
			if(Physics.Raycast(rayMouse,out hitMouse))
			{
				onHit (hitMouse);
			} else {
				missed++;
			}
		}
	}


	void onHit (RaycastHit hit)
	{
		GameObject current = hit.collider.gameObject;
		Debug.Log (rayLetter (current));
		SoundEffect.Instance.MakeBoopSound();
		CloudEffect.Instance.Explosion(hit.point);
		Destroy(current);
	}


	char rayLetter (GameObject go)
	{
		return (go.name[5]);
	}


}
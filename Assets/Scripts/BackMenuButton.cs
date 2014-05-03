using UnityEngine;
using System.Collections;

public class BackMenuButton : MonoBehaviour {

	private GUISkin skin;
	
	void Start()
	{
		skin = Resources.Load("ButtonGUI") as GUISkin;
	}
	
	void OnGUI()
	{
		const int buttonWidth = 120;
		const int buttonHeight = 60;
		
		GUI.skin = skin;
		
		if (GUI.Button(
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(4 * Screen.height / 5) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Menu"
			)
		    )
		{
			Application.LoadLevel("Menu");
		}
	}
}

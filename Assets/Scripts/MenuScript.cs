using UnityEngine;

public class MenuScript : MonoBehaviour
{
	private GUISkin skin;

	void Start()
	{
		skin = Resources.Load("ButtonGUI") as GUISkin;
	}

	void OnGUI()
	{
		const int buttonWidth = 94;
		const int buttonHeight = 60;

		GUI.skin = skin;

		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Start !"
			)
			)
		{
			Application.LoadLevel("start");
		}
	}

	void OnGUI2()
	{
		const int buttonWidth = 94;
		const int buttonHeight = 60;
		
		GUI.skin = skin;
		
		if (
			GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Quit !"
			)
			)
		{
			Application.LoadLevel("start");
		}
	}
}

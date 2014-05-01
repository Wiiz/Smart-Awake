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
		const int buttonWidth = 120;
		const int buttonHeight = 40;

		GUI.skin = skin;

		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 5) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Start !"
			)
			)
		{
			Application.LoadLevel("word");
		}

		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(3 * Screen.height / 5) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Score"
			)
		    )
		{
			Application.LoadLevel("score");
		}

		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(4 * Screen.height / 5) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Quit"
			)
		    )
		{
			Application.Quit();
		}
	}


}

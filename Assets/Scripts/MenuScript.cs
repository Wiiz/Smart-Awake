using UnityEngine;

public class MenuScript : MonoBehaviour
{
	private GUISkin skin;
	public Language defaultLanguage = Language.English;
	
	private int prevSel = 0;
	private int selection = 0;
	private string[] selections;

	void Start()
	{
		skin = Resources.Load("ButtonGUI") as GUISkin;
		LanguageManager.LoadLanguageFile(defaultLanguage);
		selections = new string[] { LanguageManager.GetText("english"), LanguageManager.GetText("french") };

	}

	void OnGUI()
	{
		const int buttonWidth = 120;
		const int buttonHeight = 40;

		GUI.skin = skin;

		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 5) - (buttonHeight / 2),
		    					  buttonWidth, buttonHeight), LanguageManager.GetText ("Commencer")))
		{
			Application.LoadLevel("word");
		}
		
		selection = GUI.SelectionGrid(new Rect (Screen.width / 7 - (buttonWidth / 2), (2 * Screen.height / 10) - (buttonHeight / 2),
		                                        buttonWidth, buttonHeight),selection, selections, selections.Length);
		
		if(prevSel != selection)
		{
			prevSel = selection;
			
			switch(selection)
			{
			case 0:
				LanguageManager.LoadLanguageFile(Language.English);
				break;
			case 1:
				LanguageManager.LoadLanguageFile(Language.French);
				break;
			}

			selections = new string[] { LanguageManager.GetText("english"), LanguageManager.GetText("french") };
		}
		
		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (3 * Screen.height / 5) - (buttonHeight / 2),
		                          buttonWidth, buttonHeight), LanguageManager.GetText ("Score")))
		{
			Application.LoadLevel("score");
		}

		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2), (4 * Screen.height / 5) - (buttonHeight / 2),
		                          buttonWidth, buttonHeight), LanguageManager.GetText ("Quitter")))
		{
			Application.Quit();
		}
	}


}

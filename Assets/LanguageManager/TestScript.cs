using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour 
{
	public Language defaultLanguage = Language.English;
	
	private int prevSel = 0;
	private int selection = 0;
	private string[] selections;
	
	void Start()
	{
		// Initialize the language manager with English language
		LanguageManager.LoadLanguageFile(defaultLanguage);
		selections = new string[] { LanguageManager.GetText("english"), LanguageManager.GetText("french") };
	}
	
	void OnGUI()
	{
		// To swap text using the Language Manager, you must use "LanguageManager.GetText(string key)" method as demonstrated in the following lines

		GUI.Label(new Rect(10,55,300,20), "Sentence 3: " + LanguageManager.GetText("Start"));
		
		selection = GUI.SelectionGrid(new Rect(10,100,Screen.width - 20,50),selection, selections, selections.Length);
		
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
			
			// In this instance we want the buttons to change there text to display in the selected language, so again we use the "LanguageManager.GetText(string key)" method
			selections = new string[] { LanguageManager.GetText("english"), LanguageManager.GetText("french") };
		}
	}
}

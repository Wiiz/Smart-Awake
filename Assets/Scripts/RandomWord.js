#pragma strict

function Start () 
{
    var myRandomString : String = RandomWordString(1);
    Debug.Log(myRandomString);
    Up();
}

function RandomWordString (length : int) : String 
{
    var wordArray : String[] = ["BONJOUR","JOUET","CACAHUETE","NUIT","DANSER","VACHE","VUE","MAMAN","PAPA","DOUDOU","PELUCHE","TABLE","TELEVISION","MASQUE","RIRE","CAMERA","LAMPE"];
    var returnString : String;
    
    for (var i : int = 0; i < length; i++) 
    {
        returnString+=wordArray[Random.Range(0, wordArray.Length)]+" ";
    }
     
     GetComponent(TextMesh).text = returnString;
     
}

function Up() 
{
	StartCoroutine(WaitAndLoad(4.0)); ;
}
function WaitAndLoad (waitTime : float) 
{
	// suspend execution for waitTime seconds
	yield WaitForSeconds (waitTime);
	Application.LoadLevel("start");
}
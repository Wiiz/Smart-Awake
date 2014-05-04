#pragma strict

var currentWord = "";



function Start () 
{
    var myRandomString : String = RandomWord(1);
    Debug.Log(myRandomString);
    Up();
}

function RandomWord(length : int) : String 
{
    var wordArray : String[] = ["BONJOUR","JOUET","CACAHUETE","NUIT","DANSER","VACHE","CARTABLE","MAMAN","PAPA","DOUDOU","PELUCHE","TABLE","TELEVISION",
    							"MASQUE","RIRE","CAMERA","LAMPE","PAUSE","VIANDE","STYLO","TROUSSE","SOURIS","ECRAN","BOUTON","CHAISE","PAPIER",
    							"FENETRE","PORTE","CLAVIER"];
    var returnWord : String;
    
    for (var i : int = 0; i < length; i++) 
    {
        returnWord += wordArray[Random.Range(0, wordArray.Length)] + " ";
    }
     
     GetComponent(TextMesh).text = returnWord;
     currentWord = returnWord;
     
}

function getCurrentWord()
{
	return (this.currentWord);
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
#pragma strict

function Start () {

}

function Update () {
	
}


function renderLetter(letter)
{
	var label = GameObject.Find("TheWord");
	var meshLabel = label.GetComponent(TextMesh);
	if(letter !== null)
		meshLabel.text += letter;
}



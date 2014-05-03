#pragma strict


var prefab : GameObject;
var gos : GameObject[];
 
function Awake()
{
	gos = new GameObject[10];
	for(var i : int = 0; i < gos.Length; i++)
	{
		var clone = Instantiate(prefab, Vector3.zero, Quaternion.identity);
		gos[i] = clone;
	}
}

function Start () {

}

function Update () {

}
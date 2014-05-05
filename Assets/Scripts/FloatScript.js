#pragma strict
 
var floatSpan = 2.0;
var speed  = 1.0;
var strayFactor : int;
var rdm : int;
var range : int;

private var startY : float;
private var startX : float;

function Start() 
{
    startY = transform.position.y;
    startX = transform.position.x;
    rdm = 0;
}

function Update()
{
	makeFloat();
}


function makeFloat()
{
  transform.position.y = startY + Mathf.Sin(Time.time * speed) * floatSpan / 2.0;
}

function makeSuffle()
{

	
	var randomX = Random.Range(-strayFactor, strayFactor);
	var randomY = Random.Range(-strayFactor, strayFactor);
	var randomZ = Random.Range(-strayFactor, strayFactor);
  
    transform.position.y = strayFactor + (startY * Mathf.Sin(Time.time * speed));
    
    transform.position.x = strayFactor + (startX * Mathf.Sin(Time.time * speed));
    
}
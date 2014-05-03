#pragma strict
 
var floatSpan = 2.0;
var speed  = 1.0;

private var startY : float;

function Start() 
{
    startY = transform.position.y;
}

function Update()
{
    transform.position.y = startY + Mathf.Sin(Time.time * speed) * floatSpan / 2.0;
}
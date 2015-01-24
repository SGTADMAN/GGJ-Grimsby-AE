#pragma strict

var target : GameObject;
var yposition : float;

function Start () {

}

function Update()
{
	if(target.transform.position.y > 0)
		this.transform.position.y = target.transform.position.y;
	this.transform.position.x = target.transform.position.x;
} 
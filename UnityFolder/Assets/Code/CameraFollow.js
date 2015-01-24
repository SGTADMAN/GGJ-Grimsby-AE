#pragma strict

var target : GameObject;
var yposition : float;

function Start () {

}

function Update()
{
this.transform.position.y = target.transform.position.y;
this.transform.position.x = target.transform.position.x;
this.transform.position.y = yposition;
} 
#pragma strict

var SpawnPoint: Transform;
var player : GameObject;

function OnTriggerEnter2D(other : Collider2D)
{
	player.transform.position = SpawnPoint.position;
	
}
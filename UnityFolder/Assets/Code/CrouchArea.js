#pragma strict

function Start () {

}
function OnTriggerEnter2D(obj: Collider2D)
{
	if(obj.gameObject.name == "player") {
		Debug.Log("Crouching");
	}
}

function Update () {

}
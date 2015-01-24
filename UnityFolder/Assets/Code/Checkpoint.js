#pragma strict

var SpawnPoint : Transform;

function OnTriggerEnter2D (other : Collider2D)
{
	SpawnPoint.position = Vector3(transform.position.x, transform.position.y, transform.position.z);
	Destroy(gameObject);
}
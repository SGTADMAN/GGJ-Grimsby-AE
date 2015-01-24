using UnityEngine;
using System.Collections;

public class RespawnCS : MonoBehaviour {

	public GameObject SpawnPoint;
	public GameObject player;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		player.transform.position = SpawnPoint.transform.position;
		Lives.Decrease ();
	}
}

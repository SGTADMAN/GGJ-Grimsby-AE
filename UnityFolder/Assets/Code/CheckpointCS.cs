using UnityEngine;
using System.Collections;

public class CheckpointCS : MonoBehaviour {

	public GameObject SpawnPoint;
	
	void OnTriggerEnter2D (Collider2D other)
	{
		SpawnPoint.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
		gameObject.SetActive(false);
	}

	public void Reset()
	{
		gameObject.SetActive (true);
	}
}

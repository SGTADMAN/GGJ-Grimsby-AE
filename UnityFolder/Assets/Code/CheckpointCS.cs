using UnityEngine;
using System.Collections;

public class CheckpointCS : MonoBehaviour {

	public GameObject SpawnPoint;
	private ButterflyMove path;
	public GameObject ClosestPath;
	private bool Active = true;
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (Active) {
			if (other.gameObject.name == "Player") {
				SpawnPoint.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y + 1.5f, gameObject.transform.position.z);
				path = GameObject.Find ("Butterfly").GetComponent<ButterflyMove> ();
				path.FirstPath = ClosestPath;
				Active = false;
			}
		}
	}

	public void Reset()
	{
		Active = true;
	}
}

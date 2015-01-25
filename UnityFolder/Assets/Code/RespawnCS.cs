using UnityEngine;
using System.Collections;

public class RespawnCS : MonoBehaviour {

	public GameObject SpawnPoint;
	public GameObject player;
	public GameObject ButterFly;
	private ButterflyMove m;
	void Start()
	{
		m = ButterFly.GetComponent<ButterflyMove> ();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		player.transform.position = SpawnPoint.transform.position;
		m.Reset ();
		Lives.Decrease ();
	}
}

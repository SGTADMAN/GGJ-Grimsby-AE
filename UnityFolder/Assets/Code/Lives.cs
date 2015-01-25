using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
	public GameObject SpawnPoint;
	public GameObject InitialSpawn;
	private static int lives;
	public int NumberOfLives;
	public GameObject checkpoints;
	private ResetCheckpoints reset;
	private ButterflyMove path;
	public GameObject ClosestPath;
	// Use this for initialization
	void Start () {
		lives = NumberOfLives;
		reset = checkpoints.GetComponent<ResetCheckpoints> ();
	}

	public static void Decrease()
	{
		lives--;
	}
	
	// Update is called once per frame
	void Update () {
	if (lives == 0) {
			SpawnPoint.transform.position = InitialSpawn.transform.position;
			gameObject.transform.position = SpawnPoint.transform.position;
			lives = NumberOfLives;
			path = GameObject.Find ("Butterfly").GetComponent<ButterflyMove> ();
			path.FirstPath = ClosestPath;
			path.Reset();
			CheckPointCollision[] c = GameObject.Find("Checkpoints").GetComponentsInChildren<CheckPointCollision>();
			foreach (var item in c) {
				item.Reset();
			}
			PlantCollision[] p = GameObject.Find("Plants").GetComponentsInChildren<PlantCollision>();
			foreach (var item in p) {
				item.Reset();
			}
			reset.Reset();
		}
	}
}

using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {
	public GameObject SpawnPoint;
	public GameObject InitialSpawn;
	private static int lives;
	public int NumberOfLives;
	public GameObject checkpoints;
	private ResetCheckpoints reset;
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
			reset.Reset();
		}
	}
}

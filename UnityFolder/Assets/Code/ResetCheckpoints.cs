using UnityEngine;
using System.Collections;

public class ResetCheckpoints : MonoBehaviour {

	CheckpointCS[] checkpoints;

	public void Reset()
	{
		foreach (var item in checkpoints) {
			item.Reset();
				}
	}

	// Use this for initialization
	void Start () {
		checkpoints = gameObject.GetComponentsInChildren<CheckpointCS> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

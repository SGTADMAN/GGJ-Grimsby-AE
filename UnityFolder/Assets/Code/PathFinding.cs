using UnityEngine;
using System.Collections;

public class PathFinding : MonoBehaviour {
	public GameObject NextPath;
	private ButterflyMove move;
	// Use this for initialization
	void Start () {
		move = GameObject.Find ("Butterfly").GetComponent<ButterflyMove> ();
		try{
			if(NextPath == null)
				NextPath = null;
		}
		catch{
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Butterfly") {
			move.Stop(NextPath);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

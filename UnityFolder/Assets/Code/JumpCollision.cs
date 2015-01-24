using UnityEngine;
using System.Collections;

public class JumpCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Player") {
			Move.OnTheGround = true;		
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}

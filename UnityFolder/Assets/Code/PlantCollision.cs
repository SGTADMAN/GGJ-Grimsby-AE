using UnityEngine;
using System.Collections;

public class PlantCollision : MonoBehaviour {
	public Animator anim;
	private bool growth = false;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("Collided");
		if (other.gameObject.name == "Plant_growth") {
			growth = true;
		}
	}
	// Update is called once per frame
	void Update () {
		anim.SetBool ("grow", growth);
	}
}

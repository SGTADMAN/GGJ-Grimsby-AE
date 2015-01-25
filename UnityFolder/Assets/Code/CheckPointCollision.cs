using UnityEngine;
using System.Collections;

public class CheckPointCollision : MonoBehaviour {

	public Animator anim;
	private bool growth = false;
	// Use this for initialization
	void Start () {
		
	}
	public void Reset()
	{
		growth = false;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			growth = true;
		}
	}
	// Update is called once per frame
	void Update () {
		anim.SetBool ("grow", growth);
	}
}

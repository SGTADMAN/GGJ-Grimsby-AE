using UnityEngine;
using System.Collections;

public class SplatCollection : MonoBehaviour {
	public Sprite[] Splats;
	SpriteRenderer rend;
	// Use this for initialization
	void Start () {
		rend = gameObject.GetComponent<SpriteRenderer> ();
		int n = Random.Range (0, Splats.Length - 1);
		rend.sprite = Splats [n];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

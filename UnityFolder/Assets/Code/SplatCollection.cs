using UnityEngine;
using System.Collections;

public class SplatCollection : MonoBehaviour {
	public Sprite[] Splats;
	SpriteRenderer renderer;
	// Use this for initialization
	void Start () {
		renderer = gameObject.GetComponent<SpriteRenderer> ();
		int n = Random.Range (0, 15);
		renderer.sprite = Splats [n];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

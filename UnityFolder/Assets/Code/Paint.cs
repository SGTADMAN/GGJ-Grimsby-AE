using UnityEngine;
using System.Collections;

public class Paint : MonoBehaviour {
	public Sprite[] paints;
	private SpriteRenderer render;
	// Use this for initialization
	void Start () {
		render = gameObject.GetComponent<SpriteRenderer> ();
	}

	public void Red ()
	{
		render.sprite = paints [0];
	}

	// Update is called once per frame
	void Update () {
	
	}
}

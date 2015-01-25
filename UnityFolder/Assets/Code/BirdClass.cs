using UnityEngine;
using System.Collections;

public class BirdClass : MonoBehaviour {
	private float Speed;
	private GameObject player;
	// Use this for initialization
	void Start () {
		Speed = Random.Range (2, 4);
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x - Speed, 0);

	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.Find ("Player");
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 0);
		if (player.transform.position.x - 9 > gameObject.transform.position.x) {
			GameObject.Destroy(gameObject);	
		}
	}
}

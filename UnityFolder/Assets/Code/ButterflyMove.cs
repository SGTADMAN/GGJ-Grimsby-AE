using UnityEngine;
using System.Collections;

public class ButterflyMove : MonoBehaviour {
	public float Speed;
	public GameObject Player;
	bool isMoving = false;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x + Speed, rigidbody2D.velocity.y); 
		isMoving = false;
	}
	public void Reset()
	{
		Debug.Log ("Reset");
		gameObject.transform.position = new Vector3 (Player.transform.position.x + 4, gameObject.transform.position.y, 0); 
	}
	///Update is called once per frame
	void Update () {
		if (Player.transform.position.x + 6 < gameObject.transform.position.x) {
			rigidbody2D.velocity = new Vector2 (0, 0);	
			isMoving = true;
		} else {
			if(isMoving)
			{
				Start();
			}
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, rigidbody2D.velocity.y);
		}

	}
}

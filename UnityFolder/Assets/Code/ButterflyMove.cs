using UnityEngine;
using System.Collections;

public class ButterflyMove : MonoBehaviour {
	public float Speed;
	public GameObject Player;
	public GameObject FirstPath { get; set; }
	public GameObject Path;
	bool isMoving = false;
	// Use this for initialization
	void Start () {
		FirstPath = Path;
		//rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x + Speed, rigidbody2D.velocity.y); 
		Reset ();
	}
	public void Reset()
	{
		Go ();
		isMoving = false;
		gameObject.transform.position= new Vector3(Player.transform.position.x + 4, Player.transform.position.y - 0.2f);
		Path = FirstPath;
	}
	public void Stop(GameObject o)
	{
		rigidbody2D.velocity = new Vector2 (0, 0); 
		if (o != null) {
			Path = o;
			Go ();
		}
	}
	public void Go()
	{
		if (gameObject.transform.position.x < Path.transform.position.x) {
			rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x + Speed, rigidbody2D.velocity.y);
		} else {
			rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
		}

		if (gameObject.transform.position.y < Path.transform.position.y) {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 0);
			if(gameObject.transform.position.y < Path.transform.position.y - 0.1f )
				rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, rigidbody2D.velocity.y + Speed);
		} else {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 0);
			if(gameObject.transform.position.y > Path.transform.position.y){
					rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, rigidbody2D.velocity.y - Speed);
			}
		}

	}
	///Update is called once per frame
	void Update () {
		if (Player.transform.position.x + 6 < gameObject.transform.position.x) {
			rigidbody2D.velocity = new Vector2 (0, 0);
			isMoving = true;
		} else {
			if(isMoving)
			{
				Go ();
			}
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, rigidbody2D.velocity.y);
			Go ();
		}

	}
}

using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public GameObject Stunt;
	public float Speed;
	private float speed;
	GameObject g;
	private float X;
	public static bool clicked = false;
	// Use this for initialization
	void Start () {
		g = GameObject.Find ("player");
		speed = Speed;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			var mousePos = Camera.main.ScreenPointToRay(Input.mousePosition);
			var point = mousePos.origin;
			if(GameObject.Find("stunt(Clone)") != null)
			{
				GameObject go = GameObject.Find("stunt(Clone)");
				GameObject.Destroy(go);
			}
			Instantiate(Stunt, new Vector3(point.x, point.y, 0), Quaternion.identity);
			clicked = true;
			X = point.x;
			Speed = speed;
			DetectCollision.Arrived = false;
		}
		Vector3 pos = g.transform.position;
		if (clicked == true) {
			if (X > pos.x) {
				g.transform.position = new Vector3 (pos.x + Speed, pos.y, pos.z);
				DetectCollision.Arrived = false;
			} else if (X < pos.x) {
				g.transform.position = new Vector3 (pos.x - Speed, pos.y, pos.z);
				DetectCollision.Arrived = false;
			} 
		} else {
			Speed = 0;
		}
	}
}

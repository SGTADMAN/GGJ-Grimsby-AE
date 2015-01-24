using UnityEngine;
using System.Collections;

public class TalkToNPC : MonoBehaviour {
	// Use this for initialization
	public GameObject TextBox;
	Vector3 position;
	private bool clicked = false;
	private int count = 0;
	void Start () {
		TextBox.transform.localScale = new Vector3 (20, 6, 0);
	}
	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.name == "player") {
			GameObject go = GameObject.Find("TextBox(Clone)");
			GameObject.Destroy(go);
		}
	}
	void OnMouseDown()
	{
		Debug.Log ("Mouse Click");
		clicked = true;
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "player") {
			Debug.Log ("Trigger");
			if (clicked == true && count < 1) {
				Debug.Log ("TextBox");
				if (GameObject.Find ("TextBox(Clone)") != null) {
						GameObject go = GameObject.Find ("TextBox(Clone)");
						GameObject.Destroy (go);
				}
				position = GameObject.Find ("player").transform.position;
				Instantiate (TextBox, new Vector3 (position.x, -4, 0), Quaternion.identity);
				clicked = false;
				count++;
			}
		}
	}
	// Update is called once per frame
	void Update () {

	}
}

using UnityEngine;
using System.Collections;

public class PassNPC : MonoBehaviour {
	public GameObject Bubble;
	void Start () {
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "player") {
			Instantiate(Bubble, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.3f, 0), Quaternion.identity);
		}
	}
	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.name == "player") {
			GameObject go = GameObject.Find("BubbleBox(Clone)");
			GameObject.Destroy(go);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}

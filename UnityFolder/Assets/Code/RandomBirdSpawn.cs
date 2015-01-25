using UnityEngine;
using System.Collections;

public class RandomBirdSpawn : MonoBehaviour {
	public GameObject bird;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int number = Random.Range (1, 100);
		if (number == 3) {
			float height = Random.Range(2.0f, 3.7f);
			GameObject.Instantiate(bird, new Vector3(gameObject.transform.position.x + 10, height, 0), Quaternion.identity);
		}
	}
}

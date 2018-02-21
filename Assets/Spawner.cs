using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] options;

	// Use this for initialization
	void Start () {
		spawnNext();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void spawnNext() {
		// Random Index
		int i = Random.Range(0, options.Length);

		// Spawn Group at current Position
		Instantiate(options[i],
			transform.position,
			Quaternion.identity);
	}
}

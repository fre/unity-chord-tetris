using UnityEngine;
using System.Collections;

public class board : MonoBehaviour {

	public int width = 4;
	public int height = 10;
	public note note;
	public note[,] notes;
	public int cellSize = 40;

	// Use this for initialization
	void Start () {
		notes = new note[width, height];
		notes [0, height - 1] = note;
		StartCoroutine (UpdateNotes ());
	}
	
	// Update is called once per frame
	IEnumerator UpdateNotes () {
		for (;;) {
			Fall ();
			Display ();
			yield return new WaitForSeconds (1);
		}
	}

	void Fall () {
		for (int i = 0; i < width; i++) {
			for (int j = 1; j < height; j++) {
				if (!notes [i, j - 1]) {
					notes [i, j - 1] = notes [i, j];
					notes [i, j] = null;
				}
			}
		}
	}

	void Display () {
		for (int i = 0; i < width; i++) {
			for (int j = 0; j < height; j++) {
				var curNote = notes [i, j];
				if (curNote) {
					curNote.transform.localPosition = new Vector3 (i, j, 0) * cellSize;
				}
			}
		}
	}
}

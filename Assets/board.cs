using UnityEngine;
using System.Collections;

public class board : MonoBehaviour {

	public int width = 4;
	public int height = 10;
	public note[,] board;

	// Use this for initialization
	void Start () {
		board = new note[width, height];
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}

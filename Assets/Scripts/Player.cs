using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Board Board;

	void Start () {
		Board = GameObject.Find("Board").GetComponent<Board>();

		if (Board.is_free_in(5,0) == 1)
		{
			Board.take_place(2,0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

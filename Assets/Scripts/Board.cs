using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

	private int[][] matrix = new int[8][8];
	private int[]	poins = new int[2]{12, 12};
	private int i,j;
	private GameManager GameManager;

	void Start () {
		GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		setupMatrix();
		i = 8;
		j = 8;
		while(i-- != 0)
			while (j-- != 0)
				Debug.Log(matrix[i][j] + " ");
				//matrix[i][j] = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public int is_free_in(int x, int y)
	{
		return matrix[i][j];
	}

	public void take_place(int x, int y, int actualPlayer)
	{
		matrix[i][j] == actualPlayer;
	}
	
	public void Erase_Poin(int x, int y)
	{
		poins[actualPlayer - 1]--;
		if (poins[actualPlayer - 1] == 0)
			GameManager.GameOver = true;
	}

	private void setupMatrix()
	{
		i = 0;
		j = 0;
		while (i != 2)
			while (j != 0){
				matrix[i++][j] = 1;
				j = j + 2;
			}
		i = 6;
		j = 0;
		while (i != 8)
			while (j != 0){
				matrix[i++][j] = 2;
				j = j + 2;
			}
	}

}

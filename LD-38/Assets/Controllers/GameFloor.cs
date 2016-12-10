using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFloor : MonoBehaviour {
	
	public GameObject[] tiles;
	public int rows = 10;
	public int columns = 10;

	private Transform floor_holder;
	// Use this for initialization
	void Start () {
		floor_holder = new GameObject ("floor").transform;

		for (int x = 0; x<columns; x++)
		{
			for (int y = 0; y < rows; y++)
			{
				GameObject tile_to_instantiate = tiles [Random.Range (0, tiles.Length)];
				GameObject tile_instance = Instantiate (tile_to_instantiate, new Vector3 (x / 10.0f, y / 10.0f, 0f), Quaternion.identity) as GameObject;
				tile_instance.transform.parent = floor_holder;
			}

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

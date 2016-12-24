using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssemblyCSharp
{

public enum Direction {RIGHT,LEFT};

public class PlayerController : MonoBehaviour 
	{

	public Player player;
	public Transform playerTransform;
	
	public Direction lastDirection = Direction.RIGHT;


	// Use this for initialization
	void Start () 
	{
		playerTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () 
	{	
		checkForMovement ();
		checkForInteraction ();
	}


	 
	private void checkInput ()
	{
		checkForMovement ();
		checkForInteraction ();
		checkForAttack ();
	}

	private void checkForInteraction()
	{
		if (Input.GetKeyDown(KeyCode.Z))
		{
			Debug.Log("INTERACT BECAUSE Z");
		}
	}

	private void checkForAttack()
	{
		// if left mouse click
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("Normal Attack");
		}
		// if right mouse click
		if (Input.GetMouseButtonDown(1))
		{
			Debug.Log("Special Attack");
		}
	}

	private void checkForMovement()
	{
		// axis basesd movement
		float verticalMovement = Input.GetAxis("vertical");
	
		// change current facing direction - used to flip the sprite
		if (verticalMovement == 1)
		{
			lastDirection = Direction.RIGHT;
		}
		else if (verticalMovement == -1)
		{
			lastDirection = Direction.LEFT;
		}
			
		float horizontalMovement = Input.GetAxis("horizontal");
		


		// normalized movement vector
		Vector3 movement = new Vector3(verticalMovement,horizontalMovement,0.0f).normalized;
		// modifications to move speed
		float mods = player.speed * Time.deltaTime;
		movement *= mods;
		// translate the plaer position
		transform.Translate(movement);

		// update the model position.
		player.position = transform.position;		
	}
}
}

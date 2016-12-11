using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public class InteractState : IEnemyState
	{
		private readonly StatePatternEnemy enemy;
		/// <summary>
		/// Initializes a new instance of the <see cref="AssemblyCSharp.InteractState"/> class.
		/// </summary>
		/// <param name="statePatternEnemy">State pattern enemy.</param>
		public InteractState(StatePatternEnemy statePatternEnemy)
		{
			enemy = statePatternEnemy;

		}	
		/// <summary>
		/// Updates the state.
		/// </summary>
		public void updateState()	
		{
			checkHostility ();
			interact ();
		}
		/// <summary>
		/// To the state of the fight.
		/// </summary>
		public void toFightState()	
		{
			enemy.currentState = enemy.fightState;
		}
		/// <summary>
		/// Raises the trigger exit event.
		/// </summary>
		/// <param name="other">Other.</param>
		public void OnTriggerExit (Collider other)
		{

		}
		/// <summary>
		/// To the state of the chase.
		/// </summary>
		public void toChaseState()	
		{
			enemy.currentState = enemy.chaseState;

		}
		/// <summary>
		/// To the state of the natural.
		/// </summary>
		public void toNaturalState()	
		{
			enemy.currentState = enemy.naturalState;
		}
		/// <summary>
		/// To the state of the interact.
		/// </summary>
		public void toInteractState()
		{
			Debug.Log ("Super Interact mode Activated");
		}
		/// <summary>
		/// Raises the trigger enter event.
		/// </summary>
		/// <param name="other">Other.</param>
		public void OnTriggerEnter (Collider other)
		{

		}
		/// <summary>
		/// Interact 
		/// </summary>
		public void interact()
		{
			Debug.Log ("Interacting with something!");
		}

		public void checkHostility()
		{
			// TODO
		}
	}
}


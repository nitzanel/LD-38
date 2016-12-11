using System;
using UnityEngine;

namespace AssemblyCSharp
{
	/// <summary>
	/// Natural state.
	/// The enemy will walk randomly around.
	/// </summary>
	public class NaturalState : IEnemyState
	{
		
		private readonly StatePatternEnemy enemy;

		/// <summary>
		/// Initializes a new instance of the <see cref="AssemblyCSharp.NaturalState"/> class.
		/// </summary>
		/// <param name="statePatternEnemy">State pattern enemy.</param>
		public NaturalState(StatePatternEnemy statePatternEnemy)
		{
			enemy = statePatternEnemy;
		}

		/// <summary>
		/// Raises the trigger enter event.
		/// </summary>
		/// <param name="other">Other.</param>
		public void OnTriggerEnter (Collider other)
		{
			if (other.gameObject.CompareTag ("Player"))
				toInteractState ();
				
		}
		/// <summary>
		/// To the state of the interact.
		/// </summary>
		public void toInteractState()
		{ 
			enemy.currentState = enemy.interactState;
		}

		/// <summary>
		/// Updates the state.
		/// </summary>
		public void updateState()
		{
			goAround ();
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
			Debug.Log ("SUPER NATURAL STATE ACTIVATED");
		}
			
		/// <summary>
		/// Go around.
		/// </summary>
		public void goAround()
		{
			// TODO
		}

	}
}


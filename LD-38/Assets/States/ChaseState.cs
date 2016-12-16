using System;
using UnityEngine;

namespace AssemblyCSharp
{
	/// <summary>
	/// Chase state.
	/// </summary>
	public class ChaseState : IEnemyState
	{
		private readonly StatePatternEnemy enemy;

		public ChaseState(StatePatternEnemy statePatternEnemy)
		{
			enemy = statePatternEnemy;
		}		
		public void updateState()
		{
			chase ();
		}
		public void toFightState()
		{
			enemy.currentState = enemy.fightState;
		}
		public void toChaseState()
		{
			Debug.Log ("SUPER CHASE IS ON!");
		}
		public void toNaturalState()	
		{
			enemy.currentState = enemy.naturalState;
		}
		public void toInteractState()	
		{
			enemy.currentState = enemy.interactState;
		}
		public void OnTriggerExit (Collider other)
		{

		}
		public void OnTriggerEnter (Collider other)	
		{
			if (other.gameObject == enemy.target)
			{
				toInteractState ();
			}

		}
		/// <summary>
		/// Chase target.
		/// </summary>
		public void chase()
		{
			Vector3 targetPosition = enemy.target.transform.position;
			Vector3 currentPosition = enemy.transform.position;
			Vector3 toTarget = (targetPosition - currentPosition).normalized;
			enemy.transform.position += toTarget * enemy.enemy_data.speed * Time.deltaTime;
		}


	}
}


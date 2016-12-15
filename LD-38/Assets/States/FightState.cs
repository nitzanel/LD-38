using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public class FightState : IEnemyState
	{
		private readonly StatePatternEnemy enemy;

		public FightState(StatePatternEnemy statePatternEnemy)
		{
			enemy = statePatternEnemy;
		}

		public void updateState()	
		{
			targetAlive =  fight ();
			if (!targetAlive)
			{
				enemy.target = enemy.getRandomTarget();
				this.toChaseState();
			}
		}
		public void toFightState()	
		{
			Debug.Log ("FIGHT SUPER POWERS!");
		}
		public void toChaseState()	
		{
			enemy.currentState = enemy.chaseState;
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
			if (other.gameObject == enemy.target)
				toChaseState ();
		}
		public void OnTriggerEnter (Collider other)
		{

		}
		/// <summary>
		/// Fight this enemy's target
		/// </summary>
		public bool fight()
		{
			// Call the attack function of the enemy model againts the target model	
			return (enemy.enemy_data.attack(enemy.target.enemy_data));		
		}



	}
}


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

		}
		public void toFightState()	
		{

		}
		public void toChaseState()	
		{

		}
		public void toNaturalState()	
		{

		}
		public void toInteractState()
		{

		}

		public void OnTriggerEnter (Collider other)
		{

		}


	}
}


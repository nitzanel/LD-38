using System;
using UnityEngine;

namespace AssemblyCSharp
{
	/// <summary>
	/// Natural state.
	/// The enemy will walk randomly around
	/// </summary>
	public class NaturalState : IEnemyState
	{
		private readonly StatePatternEnemy enemy;

		public NaturalState(StatePatternEnemy statePatternEnemy)
		{
			enemy = statePatternEnemy;
		}

		public void OnTriggerEnter (Collider other)
		{
			if (other.gameObject.CompareTag ("Player"))
				toInteractState ();
				
		}

		public void toInteractState()
		{
			
		}



		public void updateState()
		{
			goAround ();
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
			
		public void goAround()
		{
			
		}

	}
}


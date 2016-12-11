using System;
using UnityEngine;

namespace AssemblyCSharp
{
	public interface IEnemyState
	{
		void updateState();
		void OnTriggerEnter (Collider other);
		void OnTriggerExit (Collider other);
		void toFightState();
		void toChaseState();
		void toNaturalState();
		void toInteractState();
	}
}


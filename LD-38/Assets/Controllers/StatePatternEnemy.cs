using UnityEngine;
using System.Collections;

namespace AssemblyCSharp
{
	
	public class StatePatternEnemy : MonoBehaviour 
	{

		public bool isHostile = true;
		public WorldController worldController;
		public GameObject target;
		public Enemy enemy_data;

		[HideInInspector] public Transform chaseTarget;
		[HideInInspector] public IEnemyState currentState;
		[HideInInspector] public ChaseState chaseState;
		[HideInInspector] public FightState fightState;
		[HideInInspector] public NaturalState naturalState;
		[HideInInspector] public InteractState interactState;

		///
		/// returns a random enemy from the world controller
		/// the random enemy will be with different hostility then this enemy
		public GameObject getRandomEnemy()
		{
			GameObject randomEnemy;
			// POSSIBLE PROBLEM - MAY NOT EXIT IF ALL ENEMIES ARE OF SAME HOSTILITY
			// FIND SOLUTION FOR THIS PROBLEM
			while (true)
			{
				randomEnemy = worldController.enemies [Random.Range (0, worldController.enemies.Length)];
				if (randomEnemy.GetComponent<StatePatternEnemy>().isHostile != this.isHostile)
				{
					return randomEnemy;
				}
				
			}
		}

		private void Awake()
		{
			chaseState = new ChaseState (this);
			fightState = new FightState (this);
			naturalState = new NaturalState (this);
			interactState = new InteractState (this);
		}

		// Use this for initialization
		void Start () 
		{
			currentState = chaseState;
		}

		// Update is called once per frame
		void Update () 
		{
			/// consider sending the time.deltaTime
			/// may not need to send it -  its possible to get the time.deltatime from unityEngine
			currentState.updateState ();
		}
		/// <summary>
		/// Raises the trigger enter event.
		/// </summary>
		/// <param name="other">Other.</param>
		private void OnTriggerEnter(Collider other)
		{
			currentState.OnTriggerEnter (other);
		}
		/// <summary>
		/// Raises the trigger leave event.
		/// </summary>
		/// <param name="other">Other.</param>
		private void OnTriggerExit(Collider other)
		{
			currentState.OnTriggerExit (other);
		}
	}
}

using UnityEngine;
using System.Collections;

namespace AssemblyCSharp
{
	
	public class StatePatternEnemy : MonoBehaviour 
	{

		[HideInInspector] public Transform chaseTarget;
		[HideInInspector] public IEnemyState currentState;
		[HideInInspector] public ChaseState chaseState;
		[HideInInspector] public FightState fightState;
		[HideInInspector] public NaturalState naturalState;
//		[HideInInspector] public NavMeshAgent navMeshAgent;

		private void Awake()
		{
			chaseState = new ChaseState (this);
			fightState = new FightState (this);
			naturalState = new NaturalState (this);

			//navMeshAgent = GetComponent<NavMeshAgent> ();
		}

		// Use this for initialization
		void Start () 
		{
			currentState = chaseState;
		}

		// Update is called once per frame
		void Update () 
		{
			currentState.updateState ();
		}

		private void OnTriggerEnter(Collider other)
		{
			//currentState.OnTriggerEnter (other);
		}
	}
}
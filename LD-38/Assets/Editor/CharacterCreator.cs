using UnityEngine;
using System.Collections;
using UnityEditor;

namespace AssemblyCSharp
{
	public class CharacterCreator : ScriptableWizard 
	{

		public Sprite characterSprite;
		public RuntimeAnimatorController animatorController;
		public string enemy_name = "Default Name";
		public int money;
		public int health;
		public int level;
		public float speed;
		public int damage;
		public bool isHostile;

		[MenuItem ("My Tools/Create Character Wizard...")]
		static void CreateWizard()
		{
			ScriptableWizard.DisplayWizard<CharacterCreator> ("Create Character", "Create new", "Update selected");
		}

		void OnWizardCreate()
		{
			GameObject characterGO = new GameObject ();

			EnemyController characterComponent = characterGO.AddComponent<EnemyController> ();
			characterComponent.enemy = new Enemy (enemy_name, money, health, level,damage, isHostile);

			SpriteRenderer spriteRenderer = characterGO.AddComponent<SpriteRenderer> ();
			spriteRenderer.sprite = characterSprite;
			spriteRenderer.sortingOrder = 1;

			Animator animator = characterGO.AddComponent<Animator> ();
			animator.runtimeAnimatorController = animatorController;


			StatePatternEnemy enemyAI = characterGO.AddComponent<StatePatternEnemy> ();
			enemyAI.isHostile = isHostile;
			enemyAI.enemy_data = characterComponent.enemy;

		}

		void OnWizardOtherButton()
		{
			if (Selection.activeTransform != null)
			{
				Character characterComponent = Selection.activeTransform.GetComponent<Character>();

				if (characterComponent != null)
				{
					
				}
			}
		}

		void OnWizardUpdate()
		{
		}

	}
}
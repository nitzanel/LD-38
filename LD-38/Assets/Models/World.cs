using System;
using System.Collections.Generic;
using UnityEngine;
namespace AssemblyCSharp
{
	public class World
	{
		public World ()
		{
			player.position = Vector3.zero;
		}
		Player player = new Player(100,100,10,1);
		List<Enemy> enemies = new List<Enemy>();
	}
}


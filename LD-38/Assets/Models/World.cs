using System;
using System.Collections.Generic;
using UnityEngine;

namespace AssemblyCSharp
{
	[Serializable]
	/// <summary>
	/// World.
	/// </summary>
	public class World
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssemblyCSharp.World"/> class.
		/// </summary>
		public World ()
		{
			player.position = Vector3.zero;
		}
		Player player = new Player(100,100,10,1);
		List<Enemy> enemies = new List<Enemy>();
	}
}


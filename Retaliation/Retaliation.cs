using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace Retaliation
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class Retaliation : Mod
	{
		//public const string AssetPath = $"{nameof(Retaliation)}/Assets/";
		public class TrackDamageStats()
		{
			private List<int[]> damageData = [];

			// Add new damage set to damageData
			public void AddDamageStats(int[] dmgStats)
			{
				damageData.Add(dmgStats);
			}
			// Return one set of damage stats (i.e. damage taken, potential damage taken, and the NPC index)
			public int[] RetrieveDamageStats(int index)
			{
				return damageData[index];
			}
			// Return the entire list of damage stats (i.e. damage taken, potential damage taken, and the NPC index)
			public List<int[]> RetrieveAllDamageStats()
			{
				return damageData;
			}
			// Removes one set of damage stats
			public void ClearDamageStats(int index)
			{
				damageData.RemoveAt(index);
			}
			// Clears the entire list of damage stats
			public void ClearAllDamageStats()
			{
				damageData.Clear();
			}
		}
		
	}
}

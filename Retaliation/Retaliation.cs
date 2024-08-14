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

			public void AddDamageStats(int[] dmgStats)
			{
				damageData.Add(dmgStats);
			}
			public int[] RetrieveDamageStats(int index)
			{
				return damageData[index];
			}
			public List<int[]> RetrieveAllDamageStats()
			{
				return damageData;
			}
			public void ClearDamageStats()
			{
				damageData.Clear();
			}
		}
		
	}
}

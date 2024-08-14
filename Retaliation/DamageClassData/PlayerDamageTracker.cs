using System;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Retaliation.DamageClassData
{
    public class PlayerDamageTracker : ModPlayer
    {
        Retaliation.TrackDamageStats playerDamagerTracker = new();
        
        public override void ResetEffects()
        {
            
        }

        public override void OnHurt(Player.HurtInfo info)
        {
            base.OnHurt(info);

            // Save damage, potential damage, and attackers NPC ID if available. If no NPC is found, SourceNPCIndex returns -1.
            int[] quickDamageData = [info.Damage, info.SourceDamage, info.DamageSource.SourceNPCIndex];
            playerDamagerTracker.AddDamageStats(quickDamageData);
        }
    }
}
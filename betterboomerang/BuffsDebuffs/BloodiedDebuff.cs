using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace betterboomerang.BuffsDebuffs
{
    public class BloodiedDebuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Bloodied");
            Description.SetDefault("Slowly losing life");
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.lifeRegen -= 4;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen -= 4;
        }
    }
}
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

namespace betterboomerang.npc_sales.demolitionist
{
    public class npcsales : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Demolitionist)
            {
                if (NPC.downedBoss3 == true)
                {
                    shop.item[nextSlot].SetDefaults(mod.ItemType("ExplosiveBoomerang"));
                    nextSlot++;
                }
            }
        }
    }
}
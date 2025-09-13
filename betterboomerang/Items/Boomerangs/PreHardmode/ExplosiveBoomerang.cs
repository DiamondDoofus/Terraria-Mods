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

namespace betterboomerang.Items.Boomerangs.PreHardmode
{
    public class ExplosiveBoomerang : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Explosive Boomerang");
            Tooltip.SetDefault("Why would you think this was a good idea?");            
        }
        public override void SetDefaults()
        {
            item.height = 28;
            item.width = 16;
            item.damage = 27;
            item.useAnimation = 15;
            item.useTime = 15;
            item.noUseGraphic = true;
            item.rare = ItemRarityID.Green;
            item.value = 125000;
            item.melee = true;
            item.noMelee = true;
            item.autoReuse = false;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shoot = mod.ProjectileType("ExplosiveBoomerangProjectile");
            item.shootSpeed = 8f;
            item.knockBack = 8f;
            item.crit = 2;
            item.UseSound = SoundID.Item18;
        }
        public override bool CanUseItem(Player player)
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

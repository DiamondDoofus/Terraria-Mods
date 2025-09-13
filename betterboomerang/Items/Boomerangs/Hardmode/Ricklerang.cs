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

namespace betterboomerang.Items.Boomerangs.Hardmode
{
    public class Ricklerang : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ricklerang");
            Tooltip.SetDefault("Funniest rang I've ever seen");
        }
        public override void SetDefaults()
        {
            item.height = 56;
            item.width = 28;
            item.damage = 150;
            item.useAnimation = 24;
            item.useTime = 8;
            item.noUseGraphic = true;
            item.rare = ItemRarityID.Red;
            item.value = 400000;
            item.melee = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shoot = mod.ProjectileType("RicklerangProjectile");
            item.shootSpeed = 28f;
            item.knockBack = 5f;
            item.crit = 10;
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

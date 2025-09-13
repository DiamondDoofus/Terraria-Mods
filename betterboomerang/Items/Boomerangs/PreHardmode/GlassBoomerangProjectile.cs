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
    public class GlassBoomerangProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("GlassBoomerangProjectile");

        }
        public override void SetDefaults()
        {
            projectile.height = 22;
            projectile.width = 22;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.ranged = true;
            projectile.timeLeft = 600;
        }
    }
}
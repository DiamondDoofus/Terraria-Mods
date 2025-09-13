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
    public class ExplosiveBoomerangProjectile : ModProjectile
    {
        bool exploded = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ExplosiveBoomerangProjectile");
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
        public override void AI()
        {
            if (exploded == false)
            {
                Lighting.AddLight(projectile.position, 0.47f, 0.30f, 0f);
                int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, DustID.Smoke, 0f, 0f, 100, default(Color), 1f);
                Main.dust[dustIndex].scale = 0.1f + (float)Main.rand.Next(5) * 0.1f;
                Main.dust[dustIndex].fadeIn = 1.5f + (float)Main.rand.Next(5) * 0.1f;
                Main.dust[dustIndex].noGravity = true;
                Main.dust[dustIndex].position = projectile.Center;
                dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, DustID.Fire, 0f, 0f, 100, default(Color), 1f);
                Main.dust[dustIndex].scale = 1f + (float)Main.rand.Next(5) * 0.1f;
                Main.dust[dustIndex].noGravity = true;
                Main.dust[dustIndex].position = projectile.Center;
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (exploded == false)
            {
                Main.PlaySound(SoundID.Item14);
                projectile.damage = 35;
                for (int i = 0; i < 50; i++)
                {
                    int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width / 2, projectile.height / 2, DustID.Smoke, 0f, 0f, 100, default(Color), 2f);
                    Main.dust[dustIndex].velocity *= 1.4f;
                }
                for (int i = 0; i < 50; i++)
                {
                    int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width / 2, projectile.height / 2, DustID.Fire, 0f, 0f, 100, default(Color), 3f);
                    Main.dust[dustIndex].noGravity = true;
                    Main.dust[dustIndex].velocity *= 5f;
                }
            }
            exploded = true;
            projectile.damage = 27;
        }
        public override void ModifyHitPlayer(Player target, ref int damage, ref bool crit)
        {
            if (exploded == false)
            {
                Main.PlaySound(SoundID.Item14);
                projectile.damage = 35;
                for (int i = 0; i < 50; i++)
                {
                    int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width / 2, projectile.height / 2, DustID.Smoke, 0f, 0f, 100, default(Color), 2f);
                    Main.dust[dustIndex].velocity *= 1.4f;
                }
                for (int i = 0; i < 50; i++)
                {
                    int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width / 2, projectile.height / 2, DustID.Fire, 0f, 0f, 100, default(Color), 3f);
                    Main.dust[dustIndex].noGravity = true;
                    Main.dust[dustIndex].velocity *= 5f;
                }
            }
            exploded = true;
            projectile.damage = 27;
        }
        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Main.expertMode)
            {
                if (target.type >= NPCID.EaterofWorldsHead && target.type <= NPCID.EaterofWorldsTail)
                {
                    damage /= 5;
                }
            }
        }
    }
}
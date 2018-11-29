using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items.Projectiles
{
	public class Boomerang3Projectile : ModProjectile
	{
		public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Gel Boomer");
        }
		
		public override void SetDefaults()
		{
			projectile.width = 30;
			projectile.height = 30;
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.magic = false;
			projectile.penetrate = 20;
			projectile.timeLeft = 600;
			projectile.light = 3.0f;
			projectile.extraUpdates = 1;
		}
       

    }
}

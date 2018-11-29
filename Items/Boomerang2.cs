using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
	public class Boomerang2 : ModItem
	{
		public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Gel Bang-A-Rang");
            Tooltip.SetDefault("A little sharper for the discerning adventurer...");
        }
		
		public override void SetDefaults()
		{
            item.damage = 30;            
            item.melee = true;
            item.width = 30;
            item.height = 30;
			item.useTime = 25;
			item.useAnimation = 25;
            item.noUseGraphic = true;
            item.useStyle = 1;
			item.knockBack = 20;
			item.value = 8;
			item.rare = 6;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType ("BoomerangProjectile");
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
        public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
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
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Boomerang"), 3);
			recipe.AddIngredient(ItemID.Gel, 50); // It's a gooey mess.
			recipe.AddIngredient(ItemID.PinkGel, 10); // It's a gooey mess.
            recipe.SetResult(this);
            recipe.AddRecipe();
				
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("gelsword2"), 1);
            recipe.SetResult(this); //
            recipe.AddRecipe();
		}
    }
}
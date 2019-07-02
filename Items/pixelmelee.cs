using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixelmelee : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Melee Pixel");
            Tooltip.SetDefault("Massively increases melee weapon speed, crit, and damage.\n Immune to Knockback.\n Infinite Night Vision and Hunter buff.");
        }
        public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.value = 10000;
            item.rare = 6;
            item.accessory = true;
        }
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(74, 1); // Platinum Coins
			recipe.SetResult(this);
            recipe.AddRecipe();
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.meleeCrit += 1000;
			player.meleeDamage += 10f;
            //player.meleeSpeed += 3f;
			player.buffImmune[BuffID.WitheredWeapon] = true;
			player.noKnockback = true; // Immunity to knockback.
			player.nightVision = true; //[Night Vision buff] [BOOL]
			player.detectCreature = true; //[Hunter potion effect, makes enemies glow in darkness] [BOOL]
		}
    }
}
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixelrange : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Range Pixel");
            Tooltip.SetDefault("Massively increases range weapon crit and damage. Immune to Confused debuff.");
        }
        public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.value = 1;
            item.rare = 3;
            item.accessory = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(74, 2); // Platinum Coins
			recipe.SetResult(this);
            recipe.AddRecipe();
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.rangedCrit += 1000;
			player.rangedDamage += 10f;
			player.nightVision = true; //[Night Vision buff] [BOOL]
			player.detectCreature = true; //[Hunter potion effect, makes enemies glow in darkness] [BOOL]
			player.buffImmune[BuffID.Confused] = true;
            player.buffImmune[BuffID.Cursed] = true;
		}
    }
}
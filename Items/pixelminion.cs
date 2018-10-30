using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixelminion : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Minion Pixel");
            Tooltip.SetDefault("Underwear...");
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
			recipe.AddIngredient(74, 5); // Platinum Coins
			recipe.SetResult(this);
            recipe.AddRecipe();
		}
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.maxMinions += 20;
            player.minionDamage += 10f;
			player.buffImmune[BuffID.BrokenArmor] = true;
			player.buffImmune[BuffID.WitheredArmor] = true;
		}
    }
}
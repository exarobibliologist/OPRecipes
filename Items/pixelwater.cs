using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixelwater : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Water Pixel");
            Tooltip.SetDefault("The best way to observe a fish is to become a fish.");
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
			recipe.AddIngredient(74, 8); // Platinum Coins
			recipe.SetResult(this);
            recipe.AddRecipe();
		}
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.breathCD = 0; //[How fast your breath decreases; the higher the number, the faster] [INT]
			player.fishingSkill += 10000; //[Sets your fishing power] [INT]
			player.accFishingLine = true; //[maybe Unbreakable Fishing Line?] [BOOL]
			player.waterWalk2 = true; // [Lets you walk on water but not lava] [BOOL]
			player.accFlipper = true; // Swimming
		}
    }
}
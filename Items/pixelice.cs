using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixelice : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Ice Pixel");
            Tooltip.SetDefault("Bonuses:\n Ice Skates ability\n Tiger Climbing ability\n Immune to Chilled, Frozen, and Frostburn");
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
			recipe.AddIngredient(74, 5); // Platinum Coins
			recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.iceSkate = true; //[Ice Skate ability or decreases ice slippiness, faster movement on ice, and falling on ice won't break it] [BOOL]
			player.spikedBoots = 2; //[Set to 1 for slide-down walls, Set to 2 for hang-on walls] (like Tiger Climbing Gear)[INT]
			player.buffImmune[BuffID.Chilled] = true;
			player.buffImmune[BuffID.Frozen] = true;
			player.buffImmune[BuffID.Frostburn] = true;
        }
    }
}

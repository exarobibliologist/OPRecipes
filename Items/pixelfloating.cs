using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixelfloating : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Floating Pixel");
            Tooltip.SetDefault("Bonuses:\nInfinite Magic Carpet\nImmune to Stoned debuff");
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
			recipe.AddIngredient(74, 6); // Platinum Coins
			recipe.SetResult(this);
            recipe.AddRecipe();
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.canCarpet = true; //[When used in affiliation with p.carpet, it allows for infinite use of Magic Carpet] [BOOL]
			player.carpet = true; //[Grants the player the Magic Carpet effect] [BOOL]
			player.carpetTime = 999999999; //[How long you can fly with the Magic Carpet accessory] [INT]
			player.buffImmune[BuffID.Stoned] = true;
		}
    }
}

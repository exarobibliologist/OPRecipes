using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items       //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class bait : ModItem
    {
		public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Pixel Bait");
            Tooltip.SetDefault("This looks like fish might like it.");
        }
        public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.value = 10000;
			item.maxStack = 999; //This defines the items max stack
            item.rare = 6;
            item.bait = 50;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 5); // It's a gooey mess.
			recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}
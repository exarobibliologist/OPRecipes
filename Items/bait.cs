using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class bait : ModItem
    {
		public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Gel Bait");
            Tooltip.SetDefault("It looks really young! Are you sure you want to do that?");
        }
        public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.value = 10000;
			item.maxStack = 999; //This defines the items max stack
            item.rare = 6;
            item.bait = 90;
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
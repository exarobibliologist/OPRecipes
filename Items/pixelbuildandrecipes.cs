using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixelbuildandrecipes : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Build Range");
            Tooltip.SetDefault("Bonuses:\n Block placement range massively increased\nSpelunker buff and Watch.\nImmune to Darkness, Blackout, Obstructed, and NoBuilding debuffs");
        }

		public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.value = 1000000;
            item.rare = 6;
            item.accessory = true;
        }

		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(74, 1); // Platinum Coins
			recipe.SetResult(this);
            recipe.AddRecipe();

			
// ______          _                 
// | ___ \        (_)                
// | |_/ /___  ___ _ _ __   ___  ___ 
// |    // _ \/ __| | '_ \ / _ \/ __|
// | |\ \  __/ (__| | |_) |  __/\__ \
// \_| \_\___|\___|_| .__/ \___||___/
//                  | |              
//                  |_|              

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 10); // Dirt
            recipe.SetResult(27, 1); // makes Acorn
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 10); // Dirt
            recipe.SetResult(3, 1); // makes Stone - not worth it unless you want to liquidate a bunch of dirt in your inventory
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2,10); //Dirt
			recipe.SetResult(23, 1); //makes Gel
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 10); // Dirt
            recipe.SetResult(9, 1); // makes Wood - not worth it unless you want to liquidate a bunch of dirt in your inventory
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(22, 10); // Iron Bar
            recipe.SetResult(118, 1); // makes Hook - not really a cheap recipe, but saves some grinding
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(704, 10); // Lead Bar
            recipe.SetResult(118, 1); // makes Hook - not really a cheap recipe, but saves some grinding
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(22, 10); // Iron Bar
            recipe.SetResult(87, 1); // makes a Piggy Bank
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(704, 10); // Lead Bar
            recipe.SetResult(87, 1); // makes a Piggy Bank
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(19, 30); // Gold Bar
            recipe.SetResult(3213, 1); // makes a Money Trough
            recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(23,2); //Gel
			recipe.SetResult(3111, 1); //makes Pink Gel
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2740, 3); // Grasshoppers
			recipe.SetResult(2002, 1); // Turn into Worms
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2740, 3); // Grasshoppers
			recipe.AddIngredient(19, 1); // + Gold Bar
			recipe.SetResult(2895, 1); // Turn into Gold Worms
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2740, 66); // Grasshoppers
			recipe.SetResult(2673, 1); // Turn into Truffle Worms
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(321, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 1); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1173, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 1); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1174, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 1); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1175, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 1); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1176, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 1); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1177, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 10); // I'd be rich!
			recipe.AddRecipe();
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.blockRange += 100; //[Sets how far the player can place blocks] [INT]
			player.findTreasure = true; //[Spelunker effect, treasure glows in the dark] [BOOL]
			player.accWatch = 5; //[Displays the time at the top left of the screen] [INT]
			player.buffImmune[BuffID.NoBuilding] = true;
			player.buffImmune[BuffID.Darkness] = true;
			player.buffImmune[BuffID.Blackout] = true;
			player.buffImmune[BuffID.Obstructed] = true;
		}
    }
}
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
            item.value = 1;
            item.rare = 6;
            item.accessory = true;
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
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(74, 1); // Platinum Coins
			recipe.SetResult(this);
            recipe.AddRecipe();

//  ______ _      _    ___  ___      _               _____ _     _                 
//  |  _  (_)    | |   |  \/  |     | |             |_   _| |   (_)                
//  | | | |_ _ __| |_  | .  . | __ _| | _____  ___    | | | |__  _ _ __   __ _ ___ 
//  | | | | | '__| __| | |\/| |/ _` | |/ / _ \/ __|   | | | '_ \| | '_ \ / _` / __|
//  | |/ /| | |  | |_  | |  | | (_| |   <  __/\__ \   | | | | | | | | | | (_| \__ \
//  |___/ |_|_|   \__| \_|  |_/\__,_|_|\_\___||___/   \_/ |_| |_|_|_| |_|\__, |___/
//                                                                        __/ |    
//                                                                       |___/     

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 2); // Dirt
            recipe.SetResult(27, 1); // makes Acorn
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 2); // Dirt
            recipe.SetResult(3, 1); // makes Stone
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 2); //Dirt
			recipe.SetResult(23, 1); //makes Gel
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 2); // Dirt
            recipe.SetResult(9, 1); // makes Wood
            recipe.AddRecipe();

//  ___  ___      _                  _   _             _    
//  |  \/  |     | |                | | | |           | |   
//  | .  . | __ _| | _____    __ _  | |_| | ___   ___ | | __
//  | |\/| |/ _` | |/ / _ \  / _` | |  _  |/ _ \ / _ \| |/ /
//  | |  | | (_| |   <  __/ | (_| | | | | | (_) | (_) |   < 
//  \_|  |_/\__,_|_|\_\___|  \__,_| \_| |_/\___/ \___/|_|\_\
//                                                          
//                                                          

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(22, 10); // Iron Bar
            recipe.SetResult(118, 1); // makes Hook - not really a cheap recipe, but saves some grinding
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(704, 10); // Lead Bar
            recipe.SetResult(118, 1); // makes Hook - not really a cheap recipe, but saves some grinding
            recipe.AddRecipe();

//  ______             _                          _   _____                     _         
//  | ___ \           | |                        | | |_   _|                   | |        
//  | |_/ / __ _ _ __ | | _____    __ _ _ __   __| |   | |_ __ ___  _   _  __ _| |__  ___ 
//  | ___ \/ _` | '_ \| |/ / __|  / _` | '_ \ / _` |   | | '__/ _ \| | | |/ _` | '_ \/ __|
//  | |_/ / (_| | | | |   <\__ \ | (_| | | | | (_| |   | | | | (_) | |_| | (_| | | | \__ \
//  \____/ \__,_|_| |_|_|\_\___/  \__,_|_| |_|\__,_|   \_/_|  \___/ \__,_|\__, |_| |_|___/
//                                                                         __/ |          
//                                                                        |___/           

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

//   _____      _   _         ______ _       _      _____      _ 
//  |  __ \    | | | |        | ___ (_)     | |    |  __ \    | |
//  | |  \/ ___| | | |_ ___   | |_/ /_ _ __ | | __ | |  \/ ___| |
//  | | __ / _ \ | | __/ _ \  |  __/| | '_ \| |/ / | | __ / _ \ |
//  | |_\ \  __/ | | || (_) | | |   | | | | |   <  | |_\ \  __/ |
//   \____/\___|_|  \__\___/  \_|   |_|_| |_|_|\_\  \____/\___|_|
//                                                               
//                                                               
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(23,2); //Gel
			recipe.SetResult(3111, 1); //makes Pink Gel
			recipe.AddRecipe();

//  ______ _     _     _              ______       _ _       
//  |  ___(_)   | |   (_)             | ___ \     (_) |      
//  | |_   _ ___| |__  _ _ __   __ _  | |_/ / __ _ _| |_ ___ 
//  |  _| | / __| '_ \| | '_ \ / _` | | ___ \/ _` | | __/ __|
//  | |   | \__ \ | | | | | | | (_| | | |_/ / (_| | | |_\__ \
//  \_|   |_|___/_| |_|_|_| |_|\__, | \____/ \__,_|_|\__|___/
//                              __/ |                        
//                             |___/                         

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

//   _____               _         _                              __      _  
//  |_   _|             | |       | |                             \ \    | | 
//    | | ___  _ __ ___ | |__  ___| |_ ___  _ __   ___  ___   _____\ \  / __)
//    | |/ _ \| '_ ` _ \| '_ \/ __| __/ _ \| '_ \ / _ \/ __| |______> > \__ \
//    | | (_) | | | | | | |_) \__ \ || (_) | | | |  __/\__ \       / /  (   /
//    \_/\___/|_| |_| |_|_.__/|___/\__\___/|_| |_|\___||___/      /_/    |_| 
//                                                                           
//                                                                           
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(321, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 20); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1173, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 50); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1174, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 50); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1175, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 25); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1176, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 25); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1177, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 20); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(3230, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 10); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(3231, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 10); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(3229, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 10); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(3233, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 10); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(3232, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 10); // I'd be rich!
			recipe.AddRecipe();


//    ___  _      _                          
//   / _ \| |    | |                         
//  / /_\ \ | ___| |__   ___ _ __ ___  _   _ 
//  |  _  | |/ __| '_ \ / _ \ '_ ` _ \| | | |
//  | | | | | (__| | | |  __/ | | | | | |_| |
//  \_| |_/_|\___|_| |_|\___|_| |_| |_|\__, |
//                                      __/ |
//                                     |___/ 

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(29, 1); // Convert Life Crystals into
			recipe.SetResult(1291, 1); // Life Fruit
			recipe.AddRecipe();

/*
This is good for liquidating lots of wood, and then lots of copper, all at once, but still getting good returns.
Each tier upgrade of ore, requires 2x as much copper to create.
*/			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 1);
			recipe.SetResult(2, 2); // Dirt
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 1);
			recipe.SetResult(12, 5); // Copper Ore
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 10);
			recipe.SetResult(12, 50); // Copper Ore
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 100);
			recipe.SetResult(12, 500); // Copper Ore
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(699, 1);
			recipe.SetResult(12, 1);
			recipe.AddRecipe();

/*
Copper Ore converts to Iron Ore at 2:1
*/

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 2); // Copper Ore
			recipe.SetResult(11, 1); // Iron Ore
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(11, 1);
			recipe.SetResult(12, 2);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(700, 1); // Lead Ore
			recipe.SetResult(12, 2); // Copper Ore
			recipe.AddRecipe();
			
/*
Copper --|
         |-- 4:1
Silver --|
*/			
						
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 4);
			recipe.SetResult(14, 1); // Silver Ore
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(14, 1);
			recipe.SetResult(12, 4);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(701, 1);
			recipe.SetResult(12, 4);
			recipe.AddRecipe();

/*
Copper Ore converts to Gold Ore at 8:1
*/
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 8);
			recipe.SetResult(13, 1); // Gold Ore
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(13, 1);
			recipe.SetResult(12, 8);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(702, 1);
			recipe.SetResult(12, 8);
			recipe.AddRecipe();

/*
Copper Ore converts to Meteorite at 16:1
*/			
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 16);
			recipe.SetResult(116, 1); // Meteorite
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(116, 1);
			recipe.SetResult(12, 16);
			recipe.AddRecipe();

/*
Copper Ore converts to Demonite at 32:1
*/
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 32);
			recipe.SetResult(56, 1); // Demonite Ore
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(56, 1);
			recipe.SetResult(12, 32);
			recipe.AddRecipe();
			
/*
Copper Ore converts to Crimtane at 32:1
*/
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 32);
			recipe.SetResult(880, 1); // Demonite Ore
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(880, 1);
			recipe.SetResult(12, 32);
			recipe.AddRecipe();			

/*
Copper Ore converts to Hellstone and Obsidian at 64:1
*/
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 64);
			recipe.SetResult(174, 1); // Hellstone Ore
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(174, 1);
			recipe.SetResult(12, 64);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 64);
			recipe.SetResult(173, 1); // Obsidian Ore
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(173, 1);
			recipe.SetResult(12, 64);
			recipe.AddRecipe();

/*
Copper Ore converts to Cobalt at 128:1
*/
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 128);
			recipe.SetResult(364, 1); // Cobalt Ore
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(364, 1);
			recipe.SetResult(12, 128);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1104, 1);
			recipe.SetResult(12, 128);
			recipe.AddRecipe();

/*
Copper Ore converts to Mythril at 256:1
*/			
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 256);
			recipe.SetResult(365, 1); // Mythril Ore
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(365, 1);
			recipe.SetResult(12, 256);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1105, 1);
			recipe.SetResult(12, 256);
			recipe.AddRecipe();

/*
Copper Ore converts to Adamantite at 512:1
*/
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 512);
			recipe.SetResult(366, 1); // Adamantite Ore
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(366, 1);
			recipe.SetResult(12, 512);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1106, 1);
			recipe.SetResult(12, 512);
			recipe.AddRecipe();
			
/*
Copper Ore converts to Chlorophyte at 1024:1
*/			
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 1024);
			recipe.SetResult(947, 1); // Chlorophyte Ore
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(947, 1);
			recipe.SetResult(12, 1024);
			recipe.AddRecipe();

/*
Copper Ore converts to Luminite at 2048:1
*/
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(12, 2048);
			recipe.SetResult(3460, 1); // Luminite Ore
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(3460, 1);
			recipe.SetResult(12, 2048);
			recipe.AddRecipe();
			
//  ______            _        _       
//  | ___ \          | |      | |      
//  | |_/ /_   _  ___| | _____| |_ ___ 
//  | ___ \ | | |/ __| |/ / _ \ __/ __|
//  | |_/ / |_| | (__|   <  __/ |_\__ \
//  \____/ \__,_|\___|_|\_\___|\__|___/
//                                     
//                                     
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(206, 1); // Water Bucket...
			recipe.SetResult(207, 1); // Lava Bucket
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(206, 1); // Water Bucket...
			recipe.SetResult(1128, 1); // Lava Bucket
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1128, 1); // Water Bucket...
			recipe.SetResult(206, 1); // Lava Bucket
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(207, 1); // Water Bucket...
			recipe.SetResult(206, 1); // Lava Bucket
			recipe.AddRecipe();

//   _____           _            
//  /  __ \         | |           
//  | /  \/_ __ __ _| |_ ___  ___ 
//  | |   | '__/ _` | __/ _ \/ __|
//  | \__/\ | | (_| | ||  __/\__ \
//   \____/_|  \__,_|\__\___||___/
//                                
//                                
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2334, 1); // Wood Crate...
			recipe.AddIngredient(22, 5); // Iron Bar...
			recipe.SetResult(2335, 1); // Iron Crate
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2334, 1); // Wood Crate...
			recipe.AddIngredient(19, 5); // Gold Bar...
			recipe.SetResult(2336, 1); // Gold Crate
			recipe.AddRecipe();
		}
    }
}

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

//  ______ _      _    ___  ___      _               _____ _     _                 
//  |  _  (_)    | |   |  \/  |     | |             |_   _| |   (_)                
//  | | | |_ _ __| |_  | .  . | __ _| | _____  ___    | | | |__  _ _ __   __ _ ___ 
//  | | | | | '__| __| | |\/| |/ _` | |/ / _ \/ __|   | | | '_ \| | '_ \ / _` / __|
//  | |/ /| | |  | |_  | |  | | (_| |   <  __/\__ \   | | | | | | | | | | (_| \__ \
//  |___/ |_|_|   \__| \_|  |_/\__,_|_|\_\___||___/   \_/ |_| |_|_|_| |_|\__, |___/
//                                                                        __/ |    
//                                                                       |___/     

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 10); // Dirt
            recipe.SetResult(27, 1); // makes Acorn
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 10); // Dirt
            recipe.SetResult(3, 1); // makes Stone
            recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2,10); //Dirt
			recipe.SetResult(23, 1); //makes Gel
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(2, 10); // Dirt
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
			recipe.SetResult(73, 2); // I'd be rich!
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
			recipe.SetResult(73, 2); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1176, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 5); // I'd be rich!
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(1177, 1); // If I had a Gold Coin for every time I died poor...
			recipe.SetResult(73, 10); // I'd be rich!
			recipe.AddRecipe();

//    ___  _      _                                __  _____     __    _____                               _             
//   / _ \| |    | |                              / / / __  \ _ /  |  /  __ \                             (_)            
//  / /_\ \ | ___| |__   ___ _ __ ___  _   _     / /  `' / /'(_)`| |  | /  \/ ___  _ ____   _____ _ __ ___ _  ___  _ __  
//  |  _  | |/ __| '_ \ / _ \ '_ ` _ \| | | |   / /     / /      | |  | |    / _ \| '_ \ \ / / _ \ '__/ __| |/ _ \| '_ \ 
//  | | | | | (__| | | |  __/ | | | | | |_| |  / /    ./ /___ _ _| |_ | \__/\ (_) | | | \ V /  __/ |  \__ \ | (_) | | | |
//  \_| |_/_|\___|_| |_|\___|_| |_| |_|\__, | /_/     \_____/(_)\___/  \____/\___/|_| |_|\_/ \___|_|  |___/_|\___/|_| |_|
//                                      __/ |                                                                            
//                                     |___/                                                                             
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(20, 2); // Copper Bar...
			recipe.SetResult(22, 1); // Iron Bar
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(22, 1); // Iron Bar...
			recipe.SetResult(20, 2); // Copper Bar
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(22, 2); // Iron Bar...
			recipe.SetResult(21, 1); // Silver Bar
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(21, 1); // Silver Bar...
			recipe.SetResult(22, 2); // Iron Bar
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(21, 2); // Silver Bar...
			recipe.SetResult(19, 1); // Gold Bar
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(19, 1); // Gold Bar...
			recipe.SetResult(21, 2); // Silver Bar
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(19, 2); // Gold Bar...
			recipe.SetResult(117, 1); // Meteorite Bar
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(117, 1); // Meteorite Bar...
			recipe.SetResult(19, 2); // Gold Bar
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(117, 2); // Meteorite Bar...
			recipe.SetResult(57, 1); // Demonite Bar
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(57, 1); // Demonite Bar...
			recipe.SetResult(117, 2); // Meteorite Bar
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(57, 2); // Demonite Bar...
			recipe.SetResult(175, 1); // Hellstone Bar
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(175, 1); // Demonite Bar...
			recipe.SetResult(57, 2); // Hellstone Bar
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

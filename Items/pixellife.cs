using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixellife : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Life Pixel");
            Tooltip.SetDefault("Massively increases HP, regeneration, and defense.\n Immune to Venom and Poisoned debuff.");
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
			recipe.AddIngredient(74, 1); // Platinum Coins
			recipe.SetResult(this);
            recipe.AddRecipe();
        }
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Poisoned] = true;
			player.buffImmune[BuffID.Bleeding] = true;
			player.statLifeMax2 += 1000; //[Use p.statLifeMax2 += INT to add to player's max life] [INT]
			player.lifeRegen = 9999; //[Modifies life regeneration] [INT]
			player.statDefense += 1000; //[add to player's defense] [INT]
		}
    }
}
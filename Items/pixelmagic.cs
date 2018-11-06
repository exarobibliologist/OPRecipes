using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixelmagic : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Magic Pixel");
            Tooltip.SetDefault("Massively increases magic weapon crit, damage.\n All magic needs 0 mana.\n Massively increases mana and mana regen.\n Star Cloak buff.\n Immune to Cursed, Mana Sickness, Silenced debuffs.");
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
			recipe.AddIngredient(74, 2); // Platinum Coins
			recipe.SetResult(this);
            recipe.AddRecipe();
		}
		
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.magicCrit += 1000; //[Sets the chance for magic weapons to crit] [INT]
			player.magicDamage += 10f; //[Sets a multiplier for how much damage magic weapons deal] [FLOAT]
			player.manaCost -= 30f; // All magic weapons require 0 mana
			player.starCloak = true; //[Star Cloak effect, stars fall down upon being damaged] [BOOL]
			player.statManaMax2 += 1000; //[Add to player's max mana] [INT]
			player.manaRegen = 9999; //[Modify mana regeneration] [INT]
			player.nightVision = true; //[Night Vision buff] [BOOL]
			player.detectCreature = true; //[Hunter potion effect, makes enemies glow in darkness] [BOOL]
			player.buffImmune[BuffID.ManaSickness] = true;
			player.buffImmune[BuffID.Silenced] = true;
		}
    }
}
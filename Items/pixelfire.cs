using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixelfire : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Fire Pixel");
            Tooltip.SetDefault("Bonuses:\n Let's you walk on water, lava, and fire blocks\n Take no damage from lava\n Immune to Burning, OnFire, and Cursed Inferno debuffs");
        }
        public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.value = 1;
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
			player.waterWalk = true; // [Lets you walk on water AND lava] [BOOL]
			player.lavaImmune = true; //[Makes the player take no damage from lava] [BOOL]
			player.fireWalk = true; //[Ability to walk on meteorite and hellstone] [BOOL]
			player.buffImmune[BuffID.Burning] = true;
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.CursedInferno] = true;
		}
    }
}
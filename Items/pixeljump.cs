using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items
{
    public class pixeljump : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Jump Pixel");
            Tooltip.SetDefault("Get up. Stand up.\n C'mon throw your hands up.\n If you got the feeling, jump across the ceiling...\nMassively increases jump height and speed.\nImmune to Slow, Weak, OgreSpit, and Webbed debuffs.\nAdds Compass and Depth Meter buffs.");
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
			player.jumpSpeedBoost = 8f; //[Modifies how fast you rise when you jump, and therefore jumping distance increases] [FLOAT]
			player.moveSpeed += 30f;
			player.buffImmune[BuffID.Slow] = true;
			player.buffImmune[BuffID.Weak] = true;
			player.buffImmune[BuffID.OgreSpit] = true;
			player.buffImmune[BuffID.Webbed] = true;
			player.accCompass = 10; //[Displays information at top left, how far you are from spawn horizontally] [INT??]
			player.accDepthMeter = 10; //[Displays information at the top left, tells you your elevation] [INT]
		}
    }
}

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OPRecipes.Items.GelStuff
{
	public class gelsword2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Tsurugi");
			Tooltip.SetDefault("A little sharper for the discerning adventurer...\nRight-click for stab attack.\nIchor?");
		}
		public override void SetDefaults()
		{
			item.damage = 30;           //The damage of your weapon
			item.melee = true;          //Is your weapon a melee weapon?
			item.width = 40;            //Weapon's texture's width
			item.height = 40;           //Weapon's texture's height
			item.useTime = 20;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 20;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
			item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
			item.knockBack = 20;         //The force of knockback of the weapon. Maximum is 20
			item.value = 100000;           //The value of the weapon
			item.rare = 2;              //The rarity of the weapon, from -1 to 13
			item.UseSound = SoundID.Item1;      //The sound when the weapon is using
			item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("gelsword1"), 3);
			recipe.AddIngredient(ItemID.Gel, 50); // It's a gooey mess.
			recipe.AddIngredient(ItemID.PinkGel, 10); // It's a gooey mess.
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("Boomerang2"), 1);
            recipe.SetResult(this); //
            recipe.AddRecipe();
		}
		
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useStyle = 3;
			}
			else
			{
				item.useStyle = 1;
			}
			return base.CanUseItem(player);
			
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			if (player.altFunctionUse == 2)
			{
				target.AddBuff(BuffID.Confused, 20);
				target.AddBuff(BuffID.Frostburn, 20);
				target.AddBuff(BuffID.CursedInferno, 20);
			}
			else
			{
				target.AddBuff(BuffID.Confused, 20);
				target.AddBuff(BuffID.Frostburn, 20);
				target.AddBuff(BuffID.CursedInferno, 20);
			}
		}
	}
}


using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;
using WorhyMod.Items.Weapons.Ranged.Guns.Pistals;

namespace WorhyMod.Recipes
{
    public class OrangeZapinatorRecipe : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.ZapinatorOrange);
            recipe.AddIngredient<Comfifteen>();
            recipe.AddIngredient(ItemID.OrangeDye, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}
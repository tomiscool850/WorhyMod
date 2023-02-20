
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Recipes
{
    public class DartPistolRecipe : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.DartPistol);
            recipe.AddIngredient<TrueTissuesSamples>(20);
            recipe.AddIngredient(ItemID.CrimtaneBar, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Recipes
{
    public class VampireKnifesRecipe : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.VampireKnives);
            recipe.AddIngredient<TrueTissuesSamples>(50);
            recipe.AddIngredient(ItemID.CrimtaneBar, 75);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
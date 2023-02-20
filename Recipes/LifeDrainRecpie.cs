
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Recipes
{
    public class LifeDrainRecpie : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.SoulDrain);
            recipe.AddIngredient<TrueTissuesSamples>(35);
            recipe.AddIngredient(ItemID.CrimtaneBar, 45);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
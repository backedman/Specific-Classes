using Terraria.ID;
using Terraria.ModLoader;

namespace specificclasses.Items
{
    public class SummonerClass : ModItem
    {
        public override void SetDefaults()
        {


            item.consumable = true;
            item.useStyle = 2;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Summoner Class");
            Tooltip.SetDefault("Only be summoner");
        }

        public override bool UseItem(Player player)
        {
            classperson player = (classperson)(player.GetModPlayer(mod, "classperson"));
            if (classperson.hasClass)
            {
                return true;
            }
            mplayer.hasClass = true;
            mplayer.summonerclass = true;
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("BlankClass"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

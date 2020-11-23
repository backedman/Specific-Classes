using Terraria.ID;
using Terraria.ModLoader;

namespace specificclasses.Items
{
    public class ThrowingClass : ModItem
    {
        public override void SetDefaults()
        {


            item.consumable = true;
            item.useStyle = 2;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Throwing Class");
            Tooltip.SetDefault("Only be throwing");
        }

        public override bool UseItem(Player player)
        {
            classperson player = (classperson)(player.GetModPlayer(mod, "classperson"));
            if (classperson.hasClass)
            {
                return true;
            }
            mplayer.hasClass = true;
            mplayer.throwingclass = true;
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("BlankContract"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

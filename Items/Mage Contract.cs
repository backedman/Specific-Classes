using Terraria.ID;
using Terraria.ModLoader;

namespace specificclasses.Items
{
    public class MageClass : ModItem
    {
        public override void SetDefaults()
        {


            item.consumable = true;
            item.useStyle = 2;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Class");
            Tooltip.SetDefault("Only be magic");
        }

        public override bool UseItem(Player player)
        {
            classperson mplayer = (classperson)(player.GetModPlayer(mod, "classperson"));
            if (classperson.hasClass)
            {
                return true;
            }
            mplayer.hasClass = true;
            mplayer.meleeclass = true;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specificclasses.Items { 
    public class BlankContract : ModItem
{
    public override void SetDefaults()
    {

    }

    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Blank Contract");
        Tooltip.SetDefault("");
    }

}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameInput;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace specificclasses
{
    public class classperson : ModPlayer
    {
        public bool hasClass = false;
        public bool meleeclass = false;
        public bool rangedclass = false;
        public bool mageclass = false;
        public bool summonerclass = false;
        public bool throwingclass = false;
        public bool killedEye = false;
        public bool killedWormOrBrain = false;
        public bool killedSkelly = false;
        public bool killedBee = false;
        public bool killedSlime = false;
        public bool killedWall = false;
        public bool killedDestroyer = false;
        public bool killedTwins = false;
        public bool killedPrime = false;
        public bool killedPlant = false;
        public bool killedGolem = false;
        public bool killedFish = false;
        public bool killedCultist = false;
        public bool killedMoon = false;
    }
    public void damagenerfs(float multiplier)
    {
        player.meleeDamage *= 1f * multiplier;
        player.rangedDamage *= 1f * multiplier;
        player.minionDamage *= 1f * multiplier;
        player.magicDamage *= 1f * multiplier;
        player.thrownDamage *= 1f * multiplier;
    }
    public override void PreUpdateBuffs()
    {
        if (meleeclass)
        {
            damagenerfs(0.5f);
            player.meleeDamage = 1f;
        }
        if(rangedclass)
        {
            damagenerfs(0.5f);
            player.rangedDamage = 1f;
        }
        if(mageclass)
        {
            damagenerfs(0.5f);
            player.mageDamage = 1f;
        }
        if(summonerClass)
        {
            damagenerfs(0.5f);
            player.minionDamage = 1f;
        }
        if(throwingclass)
        {
            damagenerfs(0.5f);
            player.throwingDamage = 1f;
        }
    }
}

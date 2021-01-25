using BesinciGunOOPOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGunOOPOdev.Abstracts
{
    interface ISaleService
    {
        void Sell(Game game, Player player, Campaign campaign);
    }
}

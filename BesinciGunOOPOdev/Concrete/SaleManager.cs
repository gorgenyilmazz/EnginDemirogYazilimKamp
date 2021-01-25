using BesinciGunOOPOdev.Abstracts;
using BesinciGunOOPOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGunOOPOdev.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sell(Game game, Player player, Campaign campaign)
        {
            int withCampaign = game.PriceOfTheGame - (game.PriceOfTheGame * campaign.RateOfTheDiscount)/100;
            player.MyGames = new List<Game>();
            player.MyGames.Add(game);
            

            Console.WriteLine("{0} is sold to {1} by applied {2} campaign in {3} price", game.NameOfTheGame, player.FirstName, campaign.CampaignName, withCampaign);
        }
    }
}

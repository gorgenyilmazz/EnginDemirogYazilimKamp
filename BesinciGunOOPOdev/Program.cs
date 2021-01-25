using BesinciGunOOPOdev.Concrete;
using BesinciGunOOPOdev.Abstracts;
using BesinciGunOOPOdev.Entities;
using System;
using System.Collections.Generic;

namespace BesinciGunOOPOdev
{
    class Program
    {
        static void Main(string[] args)
        {
     
            //ADDING PLAYERS
            PlayerManager playerManager = new PlayerManager(new CheckPlayerManager());
            Player player1 = new Player()
            {
                FirstName = "Gorgen",
                PlayerId = 1,
                NationalityId = "23563752423",
                LastName = "Yilmaz",
                DateOfBirth = new DateTime(1998)
            };
            Player player2 = new Player()
            {
                FirstName = "Engin",
                PlayerId = 2,
                NationalityId = "1244124231",
                LastName = "Demirog",
                DateOfBirth = new DateTime(1985)
            };
            List<Player> players = new List<Player> {player1, player2 };

            foreach (var player in players)
            {
                playerManager.Save(player);
            }



            //ADDING CAMPAIGNS
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign
            {
                CampaignId = 1,
                CampaignName = "Yaz Kampanyasi",
                RateOfTheDiscount = 15
            };
            Campaign campaign2 = new Campaign
            {
                CampaignId = 2,
                CampaignName = "Karne Kampanyasi",
                RateOfTheDiscount = 25
            };
            List<Campaign> campaigns = new List<Campaign> { campaign1, campaign2 };

            foreach (var campaign in campaigns)
            {
                campaignManager.Add(campaign);
            }

            //SALES
            SaleManager saleManager = new SaleManager();
            Game game1 = new Game() { GameId = 1, NameOfTheGame = "God Of War", PriceOfTheGame = 50 };
            Game game2 = new Game() { GameId = 2, NameOfTheGame = "Batman Arkham Knight", PriceOfTheGame = 75 };


            saleManager.Sell(game1, player1, campaign1);
            saleManager.Sell(game2, player2, campaign2);
        }
    }
}

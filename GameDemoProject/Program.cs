using System;
using System.Collections.Generic;

namespace GameDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Id = 1; gamer.FirstName = "Yunus"; gamer.LastName = "Öztürk";
            gamer.TcNo = "14356789345"; gamer.NickName = "jigsaw"; gamer.BirthOfDay = "01.08.2002";
           

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);
            
            Game game1 = new Game() { Name = "ps2021", Price = 200 };
            Game game2 = new Game() { Name = "Mobile Legends", Price = 100 };
            List<Game> games = new List<Game>() { game1, game2 };

            Campaign campaign = new Campaign();
            campaign.Id = 3; campaign.FirstName = "Yelllow Friday"; campaign.DiscountRate = 50; campaign.CampaingDetails = "Galatasraya destek olmak için";
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            Sales sales = new Sales();
            sales.Sell(games, gamer, campaign);
        }       
    }
}
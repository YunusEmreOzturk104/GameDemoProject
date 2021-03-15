using System;
using System.Collections.Generic;

namespace GameDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1; gamer1.FirstName = "Yunus "; gamer1.LastName = "Öztürk";
            gamer1.TcNo = "14356789345"; gamer1.NickName = "jigsaw"; gamer1.BirthOfDay = "01.08.2002";
            Gamer gamer2 = new Gamer();
            gamer2.Id = 2; gamer2.FirstName = "Emre"; gamer2.LastName = "ÖzdemirOğlu"; gamer2.BirthOfDay = "02.07.2003";
            gamer2.TcNo = "2345678912"; gamer2.NickName = "Sawas@958";
            List<Gamer> gamers =new List<Gamer>() { gamer1,gamer2};

            GamerManager gamerManager = new GamerManager(new NewUserValidationManager());
            gamerManager.Add(gamers);
            
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
            sales.Sell(games, gamer2, campaign);
            sales.Sell(games, gamer1, campaign);
        }       
    }
}
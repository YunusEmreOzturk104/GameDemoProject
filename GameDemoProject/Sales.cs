using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class Sales
    {
        public void Sell(List<Game> games,Gamer gamer,Campaign campaign)
        {
            
            foreach (var game in games)
            {
                game.Price = game.Price - (game.Price * campaign.DiscountRate / 100);
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.Name + "oyunu" + campaign.FirstName + "kampanyası ile"
                    + game.Price + "TL'ye alınmıştır");
            }
        }
    }
}

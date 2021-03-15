using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.FirstName + "kampanyası eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.FirstName + "kampanyası silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.FirstName + "kampanyası güncellendi");
        }
    }
}

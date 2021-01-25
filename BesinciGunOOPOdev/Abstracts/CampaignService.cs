using BesinciGunOOPOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGunOOPOdev.Abstracts
{
    abstract class CampaignService
    {
        public void Add(Campaign campaign) 
        { 
            Console.WriteLine(campaign.CampaignName + "Campaign added to db"); 
        }
        public void Delete(Campaign campaign) 
        {
            Console.WriteLine(campaign.CampaignName + " Deleted from db"); 
        }
        public void Update(Campaign campaign)
        { 
            Console.WriteLine(campaign.CampaignName + " Campaign updated" );
        }
    }
}

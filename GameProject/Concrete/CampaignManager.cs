using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CampaignManager : ICampaignManager
    {

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " Campaign has created.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " Campaign has updated.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" Campaign has deleted.");
        }
    }
}

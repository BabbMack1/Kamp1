using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface ICampaignManager
    {
        void NewCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
    }
}

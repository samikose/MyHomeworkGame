using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeworkGame
{
    interface ICampaignService
    {
        public void CampaignAdd();
        public void CampaignDelete();
        
        void CampaignSalePrice(Game game);
    }
}

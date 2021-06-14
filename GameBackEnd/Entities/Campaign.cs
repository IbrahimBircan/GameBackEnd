using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Entities
{
    class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double CampaignDiscount { get; set; }
    }
}

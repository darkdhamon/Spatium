using Spatium_Model.Entities.Campaign;
using System.Collections.Generic;

namespace Spatium_Model.Entities.Space
{
    public class Sector
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<GurpsCampaign> Campaigns { get; set; }
    
    }
}
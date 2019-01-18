using System;
using System.Collections.Generic;
using System.Text;
using Spatium_Model.Entities.Space;

namespace Spatium_Model.Entities.Campaign
{
    public class GurpsCampaign
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StartingPoints { get; set; }
        public int StartingMaxDisadvantages { get; set; }
        public int StartingMaxAdvantages { get; set; }
        public int StartingRequiredSkillPoints { get; set; }
        public int InGameDaysSinceStart { get; set; }
        public int PartyCharacterPointsAwarded { get; set; }
        public int PartySkillPointsAwarded { get; set; }
        public string Notes { get; set; }
        
        public ICollection<Sector> Sectors { get; set; }
    }
}

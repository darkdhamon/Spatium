using System;
using System.Collections.Generic;
using System.Text;

namespace Spatium_Model.Entities.Campaign
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public PlayerType Type { get; set; }
        public DateTime Birthday { get; set; }
    }
}

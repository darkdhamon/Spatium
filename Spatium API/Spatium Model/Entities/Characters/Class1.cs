using System;
using System.Collections.Generic;
using System.Text;
using Spatium_Model.Entities.Campaign;

namespace Spatium_Model.Entities.Characters
{
    public class GURPS_Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Player Owner { get; set; }
    }
}

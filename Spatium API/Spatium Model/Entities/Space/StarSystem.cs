using System;
using System.Collections.Generic;
using System.Text;

namespace Spatium_Model.Entities.Space{
    public class StarSystem: MappableObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
    }
}

using System.Collections.Generic;

namespace Spatium_Model.Entities.Space
{
    public class Vessel : MappableObject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string Notes { get; set; }
        public int MaxCrew { get; set; }
        public List<CrewMember> Crew { get; set; }
    }
}

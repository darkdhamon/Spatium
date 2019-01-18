using Spatium_Model.Entities.Characters;

namespace Spatium_Model.Entities.Space
{
    public class CrewMember
    {
        public Vessel Vessel { get; set; }
        public GURPS_Character GurpsCharacter { get; set; }
    }
}
using System.Collections.Generic;
using Spatium_Model.Entities.Space;

namespace Spatium_API.Models.Map.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class SectorMapResponse
    {
        /// <summary>
        /// Name of the Sector
        /// </summary>
        public string SectorName { get; set; }
        /// <summary>
        /// List of StarSystems in the Sector
        /// </summary>
        public List<StarSystem> StarSystems { get; set; }
        /// <summary>
        /// List of tracked ships in the Sector
        /// </summary>
        public List<Vessel> Ships { get; set; }
    }

}

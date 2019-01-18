using System.Collections.Generic;
using Spatium_Model.Entities.Space;

namespace Spatium_API.Models.Map.Response
{
    /// <summary>
    /// </summary>
    public class SectorListResponse
    {
        /// <summary>
        /// List of Sectors
        /// </summary>
        public List<Sector> Sectors { get; set; }
    }
}
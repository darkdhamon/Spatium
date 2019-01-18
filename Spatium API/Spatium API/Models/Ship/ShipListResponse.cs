using System.Collections.Generic;
using Spatium_Model.Entities.Space;

namespace Spatium_API.Models.Ship
{
    /// <summary>
    /// </summary>
    public class ShipListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Vessel> Ships { get; set; }
    }
}
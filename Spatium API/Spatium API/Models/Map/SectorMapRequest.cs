using System.ComponentModel.DataAnnotations;

namespace Spatium_API.Models.Map
{
    /// <summary>
    /// </summary>
    public class SectorMapRequest
    {
        /// <summary>
        ///     Unique identifier for the sector you are trying to retrieve
        /// </summary>
        [Required]
        public int SectorID { get; set; }
    }
}
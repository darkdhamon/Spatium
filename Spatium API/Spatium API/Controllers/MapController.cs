using Microsoft.AspNetCore.Mvc;
using Spatium_API.Models.Map;
using Spatium_API.Models.Map.Response;

namespace Spatium_API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiVersion("2019.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class MapController : Controller
    {
        /// <summary>
        /// Gets the list of all sectors
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(SectorListResponse),200)]
        [ProducesResponseType(404)]
        public SectorListResponse AllSectors()
        {
            return new SectorListResponse();
        }

        /// <summary>
        /// Gets a list of sectors that meets the search requirements
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(SectorListResponse), 200)]
        [ProducesResponseType(404)]
        public SectorListResponse SearchSectors([FromBody] SectorFilterRequest request)
        {
            return new SectorListResponse();
        }

        /// <summary>
        /// Get a sector map by ID
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(SectorMapResponse),200)]
        [ProducesResponseType(404)]
        public SectorMapResponse SectorMap([FromBody]SectorMapRequest request)
        {
            return new SectorMapResponse();
        }

        
    }

   
}

using Microsoft.AspNetCore.Mvc;
using Spatium_API.Models.Ship;

namespace Spatium_API.Controllers
{
    /// <inheritdoc />
    /// <summary>
    /// Controller Used for interacting with Ships
    /// </summary>
    [ApiVersion("2019.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class ShipController:Controller
    {
        /// <summary>
        /// Gets the list of all sectors
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ShipListResponse AllShips()
        {
            return new ShipListResponse();
        }

        /// <summary>
        /// Gets a list of ships that meet the search requirements
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        public ShipListResponse SearchShips([FromBody]ShipFilterRequest request)
        {
            return new ShipListResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        public ShipResponse Ship([FromBody] ShipRequest request)
        {
            return new ShipResponse();
        }

        
    }
}

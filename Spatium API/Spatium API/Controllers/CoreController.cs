using Microsoft.AspNetCore.Mvc;
using Spatium_API.Models.Core.Reponse;

namespace Spatium_API.Controllers
{
    /// <summary>
    ///     Used for checking on the API Status information
    /// </summary>
    [ApiVersion("2019.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class CoreController : Controller
    {
        // GET api/values
        /// <summary>
        /// Gets the current Status of the system
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public SystemStatus SystemStatus()
        {
            var status = new SystemStatus
            {
                APIStatus = "Online"
            };
            //todo: Check Database Status
            //todo: List Versions
            return status;
        }
    }
}

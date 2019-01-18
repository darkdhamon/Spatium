using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spatium_API.Models.Core.Reponse
{
    public class SystemStatus
    {
        public string APIStatus { get; set; }
        public string DatabaseStatus { get; set; }
        public string MasterApiVersion { get; set; }
    }
}

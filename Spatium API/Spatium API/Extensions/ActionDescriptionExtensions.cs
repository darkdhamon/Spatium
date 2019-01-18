using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace Spatium_API.Extensions
{
    public static class ActionDescriptionExtensions
    {
        public static ApiVersionModel GetApiVersion(this ActionDescriptor actionDescriptor)
        {
            return actionDescriptor?.Properties
                .Where(keyValuePair => (Type) keyValuePair.Key == typeof(ApiVersionModel))
                .Select(keyValuePair => keyValuePair.Value as ApiVersionModel).FirstOrDefault();
        }
    }
}

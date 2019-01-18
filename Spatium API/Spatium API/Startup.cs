using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Spatium_API.Extensions;
using Spatium_API.Filters;
using Swashbuckle.AspNetCore.Swagger;

namespace Spatium_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiVersioning(
                o =>
                {
                    o.ApiVersionReader = new HeaderApiVersionReader("api-version");
                    o.DefaultApiVersion = new ApiVersion(2019,0,"alpha");
                    o.AssumeDefaultVersionWhenUnspecified = true;
                });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v2019.0", new Info
                {
                    Title = "Spatium API v2019.0",
                    Version = "V2019.0",
                    Contact = new Contact
                    {
                        Email = string.Empty,
                        Name = "Bronze Brown",
                        Url = "bronzeharoldbrown.com"
                    },
                    Description = "API for my Spatium Game",
                    TermsOfService = "None"
                });
                c.DocInclusionPredicate((docName, apiDesc) =>
                {
                    var actionApiVersionModel = apiDesc.ActionDescriptor?.GetApiVersion();
                    if (actionApiVersionModel == null) return true;
                    return actionApiVersionModel.DeclaredApiVersions.Any()
                        ? actionApiVersionModel.DeclaredApiVersions.Any(v => $"v{v.ToString()}" == docName)
                        : actionApiVersionModel.ImplementedApiVersions.Any(v => $"v{v.ToString()}" == docName);
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
                c.OperationFilter<ApiVersionOperationFilter>();
            });
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseApiVersioning();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v2019.0/swagger.json", "Spatium API v2019.0");
                c.RoutePrefix = string.Empty;

            });
            app.UseMvc();
        }
    }
}

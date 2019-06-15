using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using IdentityServer4;
using IdentityServer4.Models;
using Microsoft.IdentityModel.Tokens;

namespace id4server
{
    public class Startup
    {
        public IHostingEnvironment Environment { get; }

        public Startup(IHostingEnvironment environment)
        {
            Environment = environment;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
            var builder = services.AddIdentityServer()
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryApiResources(Config.GetApis())
                .AddInMemoryClients(Config.GetClients())
                .AddTestUsers(Config.GetUsers());

            if(Environment.IsDevelopment())
            {
                builder.AddDeveloperSigningCredential();                
            }
            else
            {
                throw new Exception("need to configure key material");
            }

            // services.AddAuthentication()
            //   .AddGoogle("Google", options =>
            //   {
            //       options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

            //       options.ClientId = "434483408261-55tc8n0cs4ff1fe21ea8df2o443v2iuc.apps.googleusercontent.com";
            //       options.ClientSecret = "3gcoTrEDPPJ0ukn_aYYT6PWo";
            //   })
            //   .AddOpenIdConnect("oidc", "OpenID Connect", options =>
            //   {
            //       options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
            //       options.SignOutScheme = IdentityServerConstants.SignoutScheme;

            //       options.Authority = "https://demo.identityserver.io/";
            //       options.ClientId = "implicit";

            //       options.TokenValidationParameters = new TokenValidationParameters
            //       {
            //           NameClaimType = "name",
            //           RoleClaimType = "role"
            //       };
            //   });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseIdentityServer();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

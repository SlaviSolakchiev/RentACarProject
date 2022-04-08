using System;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RentACar.Data.Models;
using RentACar.Web.Data;

[assembly: HostingStartup(typeof(RentACar.Web.Areas.Identity.IdentityHostingStartup))]

namespace RentACar.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<RentACarWebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RentACarWebContextConnection")));
            });
        }
    }
}

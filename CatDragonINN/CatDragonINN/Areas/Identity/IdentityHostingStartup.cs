using System;
using CatDragonINN.Areas.Identity.Data;
using CatDragonINN.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CatDragonINN.Areas.Identity.IdentityHostingStartup))]
namespace CatDragonINN.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CatDragonINNContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CatDragonINNContextConnection")));

                services.AddDefaultIdentity<CatDragonINNUser>()
                    .AddEntityFrameworkStores<CatDragonINNContext>();
            });
        }
    }
}
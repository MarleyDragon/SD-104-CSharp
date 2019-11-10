using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CatDragonInnWebApp.Models;

namespace CatDragonInnWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CatDragonInnWebApp.Models.Product> Product { get; set; }
        public DbSet<CatDragonInnWebApp.Models.Customer> Customer { get; set; }
        public DbSet<CatDragonInnWebApp.Models.Address> Address { get; set; }
    }
}

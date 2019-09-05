using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCWebApplicationMusicStore.Models;

namespace MVCWebApplicationMusicStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MVCWebApplicationMusicStore.Models.Music> Music { get; set; }
        public DbSet<MVCWebApplicationMusicStore.Models.Song> Songs { get; set; }
    }
}

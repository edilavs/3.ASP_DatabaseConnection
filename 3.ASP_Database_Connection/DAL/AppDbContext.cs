using _3.ASP_Database_Connection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3.ASP_Database_Connection.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { 

        }
        public DbSet<Slider> Sliders { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeSinav.Models;

namespace projeSinav.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=sinavDB.db");
        }


        public DbSet<Kullanici> Kullanicilar { get; set; }


        

    }


}


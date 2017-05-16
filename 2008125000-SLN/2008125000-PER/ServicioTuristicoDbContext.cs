using _2008125000_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2008125000_PER
{
    public class ServicioTuristicoDbContext : DbContext
    {
        public DbSet<ServicioTuristico> ServicioTuristico { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ServicioTuristicoConfiguration());

            base.OnModelCreating(modelBuilder);
        }


    }
}

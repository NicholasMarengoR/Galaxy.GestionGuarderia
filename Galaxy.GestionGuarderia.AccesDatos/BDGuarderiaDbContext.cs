using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionGuarderia.AccesDatos
{
    public class BDGuarderiaDbContext: DbContext
    {
        //public class BDGuarderiaDbContext(DbContextOptions<BDGuarderiaDbContext> options) : DbContext(options)
        public BDGuarderiaDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost, 1402; database=bdguarderia; user=sa; password=Password2024#; encrypt=false");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<string>()
                .HaveMaxLength(100);

            configurationBuilder.Conventions.Remove<CascadeDeleteConvention>();

        }

    }
}

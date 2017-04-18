using Microsoft.EntityFrameworkCore;
using System;
namespace ClsAppEntityCoreFeatures.Model
{
    public sealed class Database : DbContext
    {

        private const string DatabaseConnectionString = "Server=.\\SQLExpress;Database=DataBase;User Id=sa;Password=senha;MultipleActiveResultSets=true;";

        public Database()
        {
            
        }

        public DbSet<General> General { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatabaseConnectionString, x =>
            {                
            });
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<General>()
                .Property<DateTime?>("LastUpdate");

            //base.OnModelCreating(modelBuilder);
        }
    }
}

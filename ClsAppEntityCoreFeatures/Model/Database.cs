using Microsoft.EntityFrameworkCore;
using System;
namespace ClsAppEntityCoreFeatures.Model
{
    public sealed class Database : DbContext
    {

        private const string DatabaseConnectionString 
            = "Server=.\\SQLExpress;Database=DataBase;User Id=sa;Password=senha;MultipleActiveResultSets=true;";

        public Database()
        {
            
        }

        public DbSet<General> General { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<People> People { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatabaseConnectionString, x =>
            {                
            });
            //base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Shadow Properties
            modelBuilder.Entity<General>().Property<DateTime?>("LastUpdate");

            //Shadow Conventions
            modelBuilder.Entity<People>().ToTable("People");
            modelBuilder.Entity<Phone>().ToTable("Phone");

            //base.OnModelCreating(modelBuilder);
        }
    }
}

using CanisMajoris.Entities.Models;
using CanisMajoris.Repository.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CanisMajoris.Repository
{
    public class RepositoryContext : DbContext
    {

        #region Public Properties

        public DbSet<Company> Companies { get; set; }

        public DbSet<Employee> Employees { get; set; }

        #endregion

        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }

    }
}

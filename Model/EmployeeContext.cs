using Microsoft.EntityFrameworkCore;

namespace WebApiTest.Model
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {
        }
        public DbSet<TblEmployee> TblEmployee { get; set; }
        public DbSet<TblDesignation> TblDesignation { get; set; }
    }
}

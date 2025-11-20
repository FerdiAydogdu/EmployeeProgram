using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class EmployeeDbContext : DbContext
    {
        // Override on configuring kısayolu ile oluşturuldu.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0GL8Q52\SQLEXPRESS;Database=EmployeeDb;Integrated Security=true");
        }

        public DbSet<Department> Departments { get; set; }
    }
}

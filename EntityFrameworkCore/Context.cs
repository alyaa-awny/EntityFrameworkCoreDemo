using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore
{
    public class Context : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Branch> Branches { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=Intake43Core; Integrated Security=True");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>().HasKey(e => new { e.EmployeeId, e.Date });
            base.OnModelCreating(modelBuilder);
        }
    }
}

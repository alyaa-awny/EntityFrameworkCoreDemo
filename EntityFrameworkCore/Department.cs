namespace EntityFrameworkCore
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Project> Projects { get; set; }

    }
}

namespace EntityFrameworkCore
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}

namespace EntityFrameworkCore
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}

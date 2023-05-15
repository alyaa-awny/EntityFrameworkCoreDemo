namespace EntityFrameworkCore
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
    }

}

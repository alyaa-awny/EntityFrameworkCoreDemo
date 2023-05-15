namespace EntityFrameworkCore
{
    public class Attendance
    {
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public Employee Employee { get; set; }
    }
}

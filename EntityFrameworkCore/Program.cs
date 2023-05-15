
using EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

Context context = new Context();
#region Eager Loading
var query = context.Departments.Include(d => d.Employees);
foreach (var dept in query)
{
    foreach (var employee in dept.Employees)
    {
        Console.WriteLine(employee.Name);
    }
    Console.WriteLine(dept.Name);
}
#endregion

using Fifth_API_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Fifth_API_Project.DatabaseConnection
{
    public class EmployeeRecords:DbContext
    {
        public EmployeeRecords(DbContextOptions<EmployeeRecords>EmpOption):base(EmpOption)
        {
            
        }
        public DbSet<EmployeeModels> EmployeeData { get; set; }
    }
}

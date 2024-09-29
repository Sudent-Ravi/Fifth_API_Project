using Fifth_API_Project.Models;

namespace Fifth_API_Project.Repository.Service
{
    public interface IEmployee
    {
        List<EmployeeModels> GetEmployees();
        void AddnewData(EmployeeModels ModelEmp);
        void deleteData(int Id);
        void UpdateData(EmployeeModels ModelEmp);
    }
}

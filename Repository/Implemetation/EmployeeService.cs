using Fifth_API_Project.DatabaseConnection;
using Fifth_API_Project.Models;
using Fifth_API_Project.Repository.Service;

namespace Fifth_API_Project.Repository.Implemetation
{
    public class EmployeeService : IEmployee
    {
        private readonly EmployeeRecords _employeeService;
        public EmployeeService(EmployeeRecords employeeService)
        {
           _employeeService= employeeService;
        }
        public void AddnewData(EmployeeModels AddEmp)
        {
            try
            {
                if (AddEmp == null)
                {
                    throw new Exception("Data is nat null.");
                }
                _employeeService.EmployeeData.Add(AddEmp);
                _employeeService.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
        public List<EmployeeModels> GetEmployees()
        {
            var result = _employeeService.EmployeeData.ToList();
            return result;
        }

        public void deleteData(int Id)
        {
            var result = _employeeService.EmployeeData.FirstOrDefault(x => x.Id == Id);
            _employeeService.EmployeeData.Remove(result);
            _employeeService.SaveChanges();
        }

        public void UpdateData(EmployeeModels ModelEmp)
        {
            var result = _employeeService.EmployeeData.FirstOrDefault(x => x.Id == ModelEmp.Id);
            result.Id = ModelEmp.Id;
            result.Name = ModelEmp.Name;
            result.Address = ModelEmp.Address;
            result.Gender = ModelEmp.Gender;
            result.Gmail = ModelEmp.Gmail;
            _employeeService.EmployeeData.Update(result);
            _employeeService.SaveChanges();
        }
    }
}

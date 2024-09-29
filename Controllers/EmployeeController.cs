using Fifth_API_Project.Models;         
using Fifth_API_Project.Repository.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fifth_API_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _Connect;
        public EmployeeController(IEmployee Connect)
        {
             _Connect=Connect;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var result = _Connect.GetEmployees();
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Post(EmployeeModels EmpData)
        {
            _Connect.AddnewData(EmpData);
            return Ok("Data Added");
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _Connect.deleteData(Id);
            return Ok("Data Delete");
        }
        [HttpPut]
        public IActionResult Put(EmployeeModels EmployeeData)
        {
            _Connect.UpdateData(EmployeeData);
            return Ok("Data Updated");
        }
    }
}

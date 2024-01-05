using Microsoft.AspNetCore.Mvc;
using CoreDominationBootCamp.Models.ORM;
using CoreDominationBootCamp.Context;


namespace CoreDominationBootCamp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly CoreDominationDbContext _context;

        public EmployeeController(CoreDominationDbContext context)
        {
            _context = context;
        }

        [HttpGet("getAll")]
        public IActionResult GetAllEmployee()
        {
            var employees = _context.Employees;
            if (employees == null)
            {
                return NotFound();
            }
            return Ok(employees);
        }

        [HttpGet("getById/{id}")]
        public IActionResult GetByIdEmployee(int id)
        {
            var employee = _context.Employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPost("create")]
        public IActionResult CreateEmployee([FromBody] Employee newEmployee)
        {
            _context.Employees.Add(newEmployee);
            _context.SaveChanges();
            return Ok(newEmployee);
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee newEmployee)
        {
            var employee = _context.Employees.Find(id);
            employee.FirstName = newEmployee.FirstName;
            employee.LastName = newEmployee.LastName;
            employee.Address = newEmployee.Address;
            employee.City = newEmployee.City;
            employee.BirthDate = newEmployee.BirthDate;
            employee.AddDate = newEmployee.AddDate;
            _context.SaveChanges();
            return Ok(employee);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return Ok($"The employee with id {id} has been deleted");
        }
    }
}
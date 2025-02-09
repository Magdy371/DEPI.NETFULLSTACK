using Microsoft.AspNetCore.Mvc;
using WebAPICRUD.Models;
namespace WebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public IEnumerable<Employee> Get()
        //{
        //    var employees = _context.Employees.ToList();
        //    return employees;
        //}
        [HttpGet]
        public IActionResult Get()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Employee employee)
        {
            //Validate date
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return Ok(employee);
            }
            return BadRequest(ModelState);
        }
    }
}

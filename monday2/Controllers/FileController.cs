using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using monday2.Models;

namespace monday2.Controllers
{
    public class FileController : Controller
    {
        private readonly CompanyDbContext _context;

        public FileController(CompanyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("api/student")]
       
        public IActionResult CreateStudent([FromBody]Student student)
        {
            if (student == null)
            {
                return BadRequest("Invalid employee data.");
            }

            _context.Students.Add(student);
            _context.SaveChanges();

            return Ok(new { message = "Employee created successfully", student  });
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("api/employee")]
        public IActionResult Createtable([FromBody] Employee emp)
        {
            if (emp == null)
            {
                return BadRequest("Invalid employee data.");
            }

            _context.Employees.Add(emp);
            _context.SaveChanges();

            return Ok(new { message = "Employee created successfully", emp });
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDetails() { 
        return Ok( "Employee=1");
        }
    }
}

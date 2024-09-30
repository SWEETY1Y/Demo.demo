using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ReactAspCrud.Models;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ReactAspCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly string filePath = Path.Combine(Directory.GetCurrentDirectory(),"/home/s/Demo.demo/aspcore-frontend/Names.txt"); // Path to your text file
        private readonly StudentDbContext _studentDbContext;

        public StudentController(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        [HttpPost]
        [Route("GetName")]
        public async Task<IActionResult> Post([FromBody] NameModels nameModel)
        {
            if (nameModel == null || string.IsNullOrEmpty(nameModel.FirstName) || string.IsNullOrEmpty(nameModel.LastName))
            {
                return BadRequest("Invalid data.");
            }

            var concatenatedName = $"{nameModel.FirstName} {nameModel.LastName}";
            await System.IO.File.AppendAllTextAsync(filePath, concatenatedName + System.Environment.NewLine);

            return Ok("Name concatenated and saved.");
        }
        
    }
}




using Microsoft.AspNetCore.Mvc;
using StudentAPI.Data.Interface;
using StudentAPI.Model;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class StudentController : Controller
    {
        public IStudent _student;
        public StudentController(IStudent _student)
        {
            this._student = _student;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> getall()
        {
            var result = await _student.getall();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> post(Student student)
        {
            var result = await _student.post(student);
            return Ok(result);
        }

        [HttpDelete]

        public async Task<IActionResult> delete(int Id)
        {
            var result = _student.delete(Id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> put(int Id, UpdateStudent updatestudent)
        {
            var result = await _student.put(Id, updatestudent);
            return Ok(result);
        }
    }
}

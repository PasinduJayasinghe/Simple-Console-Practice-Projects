using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebApplication1.ServiceLayer;
using WebApplication1.Students;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class StudentController:ControllerBase
    {
        private readonly StudentDataService _layer;

        public StudentController(StudentDataService layer)
        {
            _layer = layer;
        }

        [HttpGet]
        public ActionResult<Student> GetAll() {
            var students=_layer.GetAllStudents();
            return Ok(students);    
            

           
        }

        [HttpGet("id")]
        public ActionResult GetById(int id) { 
            var student=_layer.GetById(id);
            return Ok(student);
        }

        [HttpPost]
        public ActionResult Post(Student student) {
            var createStudent = _layer.CreateStudent(student);
            if (createStudent == null) {
                return BadRequest("Nothing here");
            }
            return Ok(createStudent);
        }

        [HttpPut("id")]
        public ActionResult StudentPut(int id, Student student) {
            var updatedStudent = _layer.UpdateStudent(id, student);
            if (updatedStudent != null) {
                return NotFound("Not found");
            }
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            bool isDeleted=_layer.DeleteStudent(id);
            if (!isDeleted)
            {
                return BadRequest("Not found");
            }
            return NoContent();
        }
        
    }
}

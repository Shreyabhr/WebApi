using Students.Model;
using Students.services;
using StudentWebApi.Models;
using System.Web.Http;
using System.Web.Http.Cors;

namespace StudentWebApi.Controllers
{
    [EnableCors("*", "*","*")]
    [RoutePrefix("api/v1/students")]
    public class StudentController : ApiController
    {
        private IStudentServices _services;

        public StudentController(IStudentServices services)
        {
            _services = services;
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Json(_services.GetStudents());
        }

        [Route("{studentId}")]
        public IHttpActionResult Delete(int studentId)
        {
            try
            {
                _services.DeleteStudents(studentId);
                return Ok("Succesfully deleted " + studentId);
            }
            catch
            {
                return BadRequest("Not Found");
            }
        }

        [Route("{studentId}")]
        public IHttpActionResult Put(int studentId, StudentDTO dto)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest("Data not correct");
            }
            Student student = new Student(studentId, dto.Name, dto.RollNo, dto.Age, dto.Email, dto.Date, dto.IsMale);
            if (_services.UpdateStudents(student) != null)
            {
                return Ok(student);
            }

            return BadRequest("Data not correct");


        }

        [Route("")]
        public IHttpActionResult Post(StudentDTO dto)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest("Data not correct");
            }
            Student s = new Student(dto.StudentId, dto.Name, dto.RollNo, dto.Age, dto.Email, dto.Date, dto.IsMale);            
            _services.AddStudents(s);
            return Ok(_services.GetStudents());
        }
    }
}
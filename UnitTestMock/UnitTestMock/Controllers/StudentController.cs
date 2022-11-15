using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using UnitTestDataMock.Repo;

namespace UnitTestMock.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudent student;
        public StudentController(IStudent student)
        {
            this.student = student;
        }

        [HttpGet]
        public IActionResult GetStudent(int StudentId)
        {
            Student obj = student.DalGetStudentById(StudentId);
            string str = JsonConvert.SerializeObject(obj);
            string temp = "Imran Hassan";
            string temp2 = JsonConvert.SerializeObject(temp);
            decimal temp3 = 1221.22M;
            string temp4 = JsonConvert.SerializeObject(temp3);
            return Ok(student.DalGetStudentById(StudentId));
        }

        [HttpGet]
        public IActionResult GetAllStudent()
        {
            string Ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            List<Student> list = student.DalGetStudents();
            string str = JsonConvert.SerializeObject(list);
            List<Student> EmptyList = Enumerable.Empty<Student>().ToList();
            string strEmptyList = JsonConvert.SerializeObject(EmptyList);
            return Ok(student.DalGetStudents());
        }

        [HttpPost]
        public IActionResult DeleteStudent(int StudentId)
        {
            return Ok(student.DalDeleteStudent(StudentId));
        }

        [HttpPost]
        public IActionResult AddStudent(Student obj)
        {
            return Ok(student.DalAddStudent(obj));
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student obj)
        {
            return Ok(student.DalAddStudent(obj));
        }
    }
}

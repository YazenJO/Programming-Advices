using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Student_API_Project.Models;


namespace Student_API_Project.Controllers
{
    [ApiController]
    [Route("api/Students")]
    public class StudentsController : ControllerBase
    {
        [HttpGet("ALL")]
        public ActionResult<IEnumerable<Students>> GetAllStudents()
        {
            return Ok(StudentsDataSemulation.StudentsList);
        }
        [HttpGet("Passed")]
        public ActionResult<IEnumerable<Students>> GetPassedStudents()
        {
            var passedStudents = StudentsDataSemulation.StudentsList.Where(s => s.Grade >= 50).ToList();
            return Ok(passedStudents);  
        }
        [HttpGet("AvgGrade")]
        public ActionResult<double> GetAverageGrade()
        {
            if(!StudentsDataSemulation.StudentsList.Any())
            {
                return NotFound("No students available to calculate average grade.");
            }
            var averageGrade = StudentsDataSemulation.StudentsList.Average(s => s.Grade);
            return Ok(averageGrade);
        }
        [HttpGet("GetStudentByID/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Students> GetStudentByID(int ID)
        {
            if(!StudentsDataSemulation.StudentsList.Any())
            {
                return NotFound("No students available to calculate average grade.");
            }
            var StudentByID = StudentsDataSemulation.StudentsList.FirstOrDefault(s => s.Id == ID);
            if(StudentByID == null)
            {
                return NotFound($"Student with ID {ID} not found.");
            }
            return Ok(StudentByID);
        }
    }
}

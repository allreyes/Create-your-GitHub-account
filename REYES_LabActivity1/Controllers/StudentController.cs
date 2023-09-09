using Microsoft.AspNetCore.Mvc;
using REYES_LabActivity1.Models;


namespace REYES_LabActivity1.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Allyson",LastName = "Reyes", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.0, Email = "allysonreyes@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Karamatsu", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1.5, Email = "karamatsu@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Ichimatsu", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.0, Email = "ichimatsu@gmail.com"
                }
            };
        public IActionResult Index()
        {            
            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);
            
            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

    }
}

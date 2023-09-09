using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using REYES_LabActivity1.Models;


namespace REYES_LabActivity1.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> instructorsList = new List<Instructor>
            {
                        new Instructor(){
                            instructorID = 1,
                            instructorEmail=  "AllysonReyes@gmail.com",
                            instructorFirstName = "Allyson",
                            instructorLastName = "Reyes",
                            instructorIsTenured = "Permanent",
                            instructorDateHired = DateTime.Now,
                            instructorRank = Hello.Professor,
                          },
                        new Instructor(){
                            instructorID = 2,
                            instructorEmail=  "miaelazaur@gmail.com",
                            instructorFirstName = "Mia",
                            instructorLastName = "Elazaur",
                            instructorIsTenured = "Temporary",
                            instructorDateHired = DateTime.Now,
                            instructorRank = Hello.Professor
                          },
                            new Instructor(){
                            instructorID = 3,
                            instructorEmail=  "Lintagleo@gmail.com",
                            instructorFirstName = "Leo",
                            instructorLastName = "Lintag",
                            instructorIsTenured = "Permanent",
                            instructorDateHired = DateTime.Now,
                            instructorRank = Hello.AssistantProfessor
                          }
                    };
        public IActionResult Index()
        {
            return View(instructorsList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the instructor whose id matches the given id
            Instructor? instructor = instructorsList.FirstOrDefault(st => st.instructorID == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }
    }
}
using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{



    public class StudentController : Controller
    {
        private static List<Student> StudentList = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Ahmed Ali",
                Address = "Cairo",
                Image = "https://i.pravatar.cc/300?img=11"
            },

            new Student
            {
                Id = 2,
                Name = "Mohamed Hassan",
                Address = "Giza",
                Image = "https://i.pravatar.cc/300?img=12"
            },

            new Student
            {
                Id = 3,
                Name = "Sara Ahmed",
                Address = "Alexandria",
                Image = "https://i.pravatar.cc/300?img=13"
            },

            new Student
            {
                Id = 4,
                Name = "Omar Mahmoud",
                Address = "Mansoura",
                Image = "https://i.pravatar.cc/300?img=14"
            },

            new Student
            {
                Id = 5,
                Name = "Mariam Ali",
                Address = "Luxor",
                Image = "https://i.pravatar.cc/300?img=15"
            }
        };

        public IActionResult Index()
        {
            return View(StudentList);
        }

        public IActionResult Details(int id)
        {
            var student = StudentList.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}

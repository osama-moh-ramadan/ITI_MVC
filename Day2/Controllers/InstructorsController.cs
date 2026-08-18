using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Day2.Services;

namespace Day2.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly IInstructorService _instructorService;

        public InstructorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public async Task<IActionResult> Details(int id)
        {
            var instructor = await _instructorService.GetInstructorDetailsAsync(id);
            if (instructor == null)
                return NotFound();
            return View(instructor);
        }
    }
}
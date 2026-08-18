using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Day2.Services;

namespace Day2.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Index()
        {
            var departments = await _departmentService.GetAllDepartmentsAsync();
            return View(departments);
        }

        public async Task<IActionResult> InstructorsInDepartment(int id)
        {
            var department = await _departmentService.GetDepartmentWithInstructorsAsync(id);
            if (department == null)
                return NotFound();
            return View(department);
        }
    }
}
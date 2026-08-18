using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day2.Data;
using Day2.Models;
using Day2.Services;

namespace Day2.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ApplicationDbContext _context;

        public DepartmentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> GetAllDepartmentsAsync()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartmentWithInstructorsAsync(int departmentId)
        {
            return await _context.Departments
                .Include(d => d.Instructor)
                .FirstOrDefaultAsync(d => d.Id == departmentId);
        }
    }
}
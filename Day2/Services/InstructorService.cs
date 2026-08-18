using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Day2.Data;
using Day2.Models;
using Day2.Services;

namespace Day2.Services
{
    public class InstructorService : IInstructorService
    {
        private readonly ApplicationDbContext _context;

        public InstructorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Instructor> GetInstructorDetailsAsync(int instructorId)
        {
            return await _context.Instructors
                .Include(i => i.Department)
                .Include(i => i.Manager)
                .FirstOrDefaultAsync(i => i.Id == instructorId);
        }
    }
}
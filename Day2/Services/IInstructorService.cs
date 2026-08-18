using System.Threading.Tasks;
using Day2.Models;
using Day2.Models;

namespace Day2.Services

{
    public interface IInstructorService
    {
        Task<Instructor> GetInstructorDetailsAsync(int instructorId);
    }
}
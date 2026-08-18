using System.Collections.Generic;
using System.Threading.Tasks;
using Day2.Models;

namespace Day2.Services

{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllDepartmentsAsync();
        Task<Department> GetDepartmentWithInstructorsAsync(int departmentId);
    }
}
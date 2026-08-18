using Day2.Models;
using System;

namespace Day2.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? HireDate { get; set; }

        public int? ManagerId { get; set; }
        public virtual Instructor Manager { get; set; }
        //relation with DepartmentId
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
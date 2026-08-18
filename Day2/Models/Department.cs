using System.Collections.Generic; 

namespace Day2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ManagerName { get; set; }
            // one to many
        public virtual ICollection<Instructor> Instructor { get; set; }
    }

}
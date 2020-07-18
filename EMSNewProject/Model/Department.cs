using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSNewProject.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}

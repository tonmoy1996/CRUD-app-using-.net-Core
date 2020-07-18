using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSNewProject.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}

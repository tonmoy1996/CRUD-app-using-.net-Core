using EMSNewProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSNewProject.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EMSDBContext _context;

        
        public EmployeeRepository(EMSDBContext context)
        {
            _context = context;
        }

        public int Create(Employee employee)
        {
            _context.Employees.Add(employee);
            
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
           var emp=  _context.Employees.SingleOrDefault(p => p.Id == id);
            _context.Employees.Remove(emp);

           return _context.SaveChanges();
        }

        public Employee Get(int id)
        {
            return _context.Employees.SingleOrDefault(p=> p.Id== id);
        }

        public IEnumerable<Employee> GetAll()
        {
          
            return _context.Employees.ToList();
            
        }

        public Employee Update(Employee employee)
        {

            _context.Employees.Update(employee);
            _context.SaveChanges();
            return employee;
        }
    }
}

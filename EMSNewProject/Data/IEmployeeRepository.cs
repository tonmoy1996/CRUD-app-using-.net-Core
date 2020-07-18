using EMSNewProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSNewProject.Data
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);

        int Create(Employee employee);

        Employee Update(Employee employee);

        int Delete(int id);

    }
}

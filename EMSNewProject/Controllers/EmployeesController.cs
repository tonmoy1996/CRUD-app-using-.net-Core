using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMSNewProject.Data;
using EMSNewProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMSNewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepository repos;

        public EmployeesController(IEmployeeRepository _repos)
        {
            repos = _repos;
        }
        [HttpGet]
        public ActionResult <IEnumerable<Employee>> GetAll()
        {
            return Ok(repos.GetAll().ToList());

        }
        [HttpGet("{id}")]
        public ActionResult<Employee> get(int id)
        {
            return Ok(repos.Get(id));
        } 

        [HttpPost]
        [Route("add")]
        public int Create(Employee employee)
        {
           return repos.Create(employee);
        }

        [HttpPut]
        [Route("update")]
        public Employee Update(Employee employee)
        {
            return repos.Update(employee);
        }
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return repos.Delete(id);
        }

    }
}

using EMSNewProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSNewProject.Data
{
    public class EMSDBContext : DbContext
    {
        public EMSDBContext(DbContextOptions<EMSDBContext> opt) : base(opt)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}

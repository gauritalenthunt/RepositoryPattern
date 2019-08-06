using Repositorypattern.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorypattern.Entity
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=EmployeeEntities")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}

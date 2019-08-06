using Repositorypattern.Domain;
using Repositorypattern.Entity;
using Repositorypattern.IRepository;
using System;
using System.Collections.Generic;

namespace Repositorypattern.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext context)
            : base(context)
        {
        }

        public IEnumerable<Employee> GetEmployeeSalary(Employee Emp)
        {
            throw new NotImplementedException();
        }
    }
}

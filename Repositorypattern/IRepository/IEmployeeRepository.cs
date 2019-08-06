using Repositorypattern.Domain;
using System.Collections.Generic;

namespace Repositorypattern.IRepository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeeSalary(Employee Emp);
    }
}

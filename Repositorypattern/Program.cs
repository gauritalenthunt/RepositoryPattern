using Repositorypattern.Domain;
using Repositorypattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mail;

namespace Repositorypattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new Entity.EmployeeContext()))
            {
                var employee = new Employee();
                employee.EmployeeName = "GauriTest";
                employee.EmployeeSalary = 343453;
                unitOfWork.Employees.Add(employee);
                unitOfWork.Complete();
                Console.WriteLine("Employee details are updated");
            }
        }
    }
}

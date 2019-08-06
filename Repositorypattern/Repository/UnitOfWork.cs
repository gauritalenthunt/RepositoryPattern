using Repositorypattern.Entity;
using Repositorypattern.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorypattern.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        protected EmployeeContext _context;

        public UnitOfWork(EmployeeContext employeeContext)
        {
            _context = employeeContext;
            Employees = new EmployeeRepository(_context);
        }
        public IEmployeeRepository Employees { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

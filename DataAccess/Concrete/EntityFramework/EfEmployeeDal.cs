using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : IEmployeeDal
    {
        public void Add(Employee employee)
        {
            using (var context = new EmployeeDbContext())
            {
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }

        public int CheckIdentityNumber(string identityNumber)
        {
            using (var context = new EmployeeDbContext())
            {
                var result = context.Employees.Where(e => e.IdentityNumber == identityNumber);
                return result.Count();
            }
        }

        public List<Employee> GetAll()
        {
            using (var context = new EmployeeDbContext())
            {
                return context.Employees.ToList();
            }
        }
    }
}

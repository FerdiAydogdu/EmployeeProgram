using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal : IDepartmentDal
    {
        public List<Department> GetList()
        {
            using (var context = new EmployeeDbContext())
            { 
                var result = context.Departments.ToList();
                return result;
            }
        }
    }
}

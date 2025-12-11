using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal : IDepartmentDal
    {
        public void Add(Department department)
        {
            using (var context = new EmployeeDbContext())
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
        }

        public void Delete(Department department)
        {
            using (var context = new EmployeeDbContext())
            {
                context.Departments.Remove(department);
                context.SaveChanges();
            }
        }

        public Department GetById(int departmentId)
        {
            using (var context = new EmployeeDbContext())
            {
                //var result = context.Departments.Find(departmentId);
                var result = context.Departments.Where(c=> c.Id == departmentId).FirstOrDefault();
                return result;
            }
        }

        public List<Department> GetList()
        {
            using (var context = new EmployeeDbContext())
            {
                var result = context.Departments.ToList();
                return result;
            }
        }

        public void Update(Department department)
        {
            using (var context = new EmployeeDbContext())
            {
                context.Departments.Update(department);
                context.SaveChanges();
            }
        }
    }
}

using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDepartmentDal : EfEntityRepositoryBase<Department, EmployeeDbContext>, IDepartmentDal
    {
        public bool CheckDepartmentUses(int departmentId)
        {
            using (var context = new EmployeeDbContext())
            {
                var result = context.Employees.Where(c => c.Id == departmentId);
                return result.Count() > 0 ? false : true;
            }
        }

        public List<Department> GetList()
        {
            using (var context = new EmployeeDbContext())
            {
                //var result = context.Departments.ToList();
                var result = from department in context.Departments
                             select new Department
                             {
                                 Id = department.Id,
                                 Name = department.Name.ToUpper(),
                                 Status = department.Status 
                             };

                return result.ToList();
            }
        }

        public void StatusChange(Department department)
        {
            using (var context = new EmployeeDbContext())
            {
                if (department.Status == true)
                    department.Status = false;
                else
                    department.Status = true;

                context.Departments.Update(department);
                context.SaveChanges();
            }
        }
    }
}

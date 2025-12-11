using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IDepartmentDal
    {
        List<Department> GetList();
        void Add(Department department);
        void Delete(Department department);
        void Update(Department department);
        Department GetById(int departmentId);
    }
}

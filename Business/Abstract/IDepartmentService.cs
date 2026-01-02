using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDepartmentService
    {        
        List<Department> GetList();
        bool Add(Department department);
        void Delete(Department department);
        bool Update(Department department);
        Department GetById(int departmentId);
    }
}

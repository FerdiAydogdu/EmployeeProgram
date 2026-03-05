using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IDepartmentDal : IEntityRepository<Department>
    {
        List<Department> GetList();
        //Department GetById(int departmentId);
        bool CheckDepartmentUses(int departmentId);
        void StatusChange(Department department);
    }
}

using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IDepartmentDal
    {
        List<Department> GetList();
    }
}

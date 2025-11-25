using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetList();
    }
}

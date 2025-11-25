using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public List<Department> GetList()
        {
            return _departmentDal.GetList();
        }
    }
}

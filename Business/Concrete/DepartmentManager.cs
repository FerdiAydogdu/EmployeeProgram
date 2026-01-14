using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation.Results;


namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public bool Add(Department department)
        {
            var validation = ValidationTool.Validate(new DepartmentValidator(), department);

            if (validation)
            {
                _departmentDal.Add(department);
                MessageBox.Show("Bölüm başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            return false;
        }

        public void Delete(Department department)
        {
            _departmentDal.Delete(department);
        }

        public Department GetById(int departmentId)
        {
            return _departmentDal.GetById(departmentId);
        }

        public int GetDepartmentIdByName(string departmentName)
        {
            return _departmentDal.GetList().Where(x => x.Name==departmentName).Select(s => s.Id).FirstOrDefault();
        }

        public List<Department> GetList()
        {
            return _departmentDal.GetList();
        }

        public bool Update(Department department)
        {
            var validation = ValidationTool.Validate(new DepartmentValidator(), department);

            if (validation)
            {
                _departmentDal.Update(department);
                MessageBox.Show("Bölüm başarıyla güncellendi.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            return false;
        }
    }
}

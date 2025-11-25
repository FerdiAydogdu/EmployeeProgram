using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace EmployeeUI
{
    public partial class DepartmentList : Form
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentList(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public DepartmentList()
        {
            InitializeComponent();
        }

        private void DepartmentList_Load(object sender, EventArgs e)
        {
            // Data access bağımlılığını azaltmak için Business katmanını kullandım.

            //EmployeeDbContext context = new EmployeeDbContext();
            //var result = context.Departments.ToList();

            //dgwDepartmentList.DataSource = result;

            var result = _departmentService.GetList();
            dgwDepartmentList.DataSource = result;
        }
    }
}

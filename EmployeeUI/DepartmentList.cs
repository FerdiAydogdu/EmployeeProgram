using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class DepartmentList : Form
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentList(IDepartmentService departmentService)
        {
            InitializeComponent();
            _departmentService = departmentService;
        }

        private void DepartmentList_Load(object sender, EventArgs e)
        {
            // Data access bağımlılığını azaltmak için Business katmanını kullandım.

            //EmployeeDbContext context = new EmployeeDbContext();
            //var result = context.Departments.ToList();

            //dgwDepartmentList.DataSource = result;

            GetList();
        }

        void GetList()
        {
            var result = _departmentService.GetList();
            dgwDepartmentList.DataSource = result;
        }

        private void dgwDepartmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgwDepartmentList.Columns[e.ColumnIndex].Name == "colDelete")
                {
                    if(MessageBox.Show($"{(dgwDepartmentList.CurrentRow.Cells["colName"].Value)} bölümünü silmek istiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var department = dgwDepartmentList.CurrentRow.DataBoundItem as Department;
                        _departmentService.Delete(department);
                        GetList();
                    }
                }
            }
        }
    }
}

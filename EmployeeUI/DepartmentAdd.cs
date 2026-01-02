using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace EmployeeUI
{
    public partial class DepartmentAdd : Form
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentAdd(IDepartmentService departmentService)
        {
            InitializeComponent();
            _departmentService = departmentService;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void Department_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            Department department = new Department()
            {
                Name = txtDepartmentName.Text,
                Status = true
            };

            var result = _departmentService.Add(department);

            if (result)                          
                Clear();                                                         
        }

        void Clear()
        {
            txtDepartmentName.Text = string.Empty;
        }
    }
}

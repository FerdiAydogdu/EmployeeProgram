using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class EmployeeAdd : Form
    {
        private readonly IDepartmentService _departmentService;
        private readonly IEmployeeService _employeeService;
        public EmployeeAdd(IDepartmentService departmentService, IEmployeeService employeeService)
        {
            InitializeComponent();
            _departmentService = departmentService;
            _employeeService = employeeService;
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

        int departmentId = 0;

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadTheme();

            var departments = _departmentService.GetList();

            foreach (var department in departments)
            {
                txtDepartment.Items.Add(department.Name);
            }
        }

        private void txtDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            departmentId = _departmentService.GetDepartmentIdByName(txtDepartment.Text);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                //Name = char.ToUpper(txtName.Text[0]) + txtName.Text.Substring(1).ToLower(),
                //LastName = char.ToUpper(txtLastName.Text[0]) + txtLastName.Text.Substring(1).ToLower(),
                Name = txtName.Text.ToLower(),
                LastName = txtLastName.Text.ToLower(),
                DepartmentId = departmentId,
                BirthDate = Convert.ToDateTime(dtpBirthDate.Value),
                Salary = Convert.ToDecimal(txtSalary.Text),
                StartingDate = Convert.ToDateTime(dtpStartingDate.Value),
                IdentityNumber = txtIdentityNumber.Text,
                Status = "Çalışıyor"
            };

            var result = _employeeService.Add(employee);

            if (result)
            {

            }

        }
    }
}

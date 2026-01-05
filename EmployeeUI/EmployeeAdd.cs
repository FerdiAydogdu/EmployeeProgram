using Business.Abstract;
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
        IDepartmentService _departmentService;
        public EmployeeAdd(IDepartmentService departmentService)
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

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadTheme();

            var departments = _departmentService.GetList();

            foreach (var department in departments)
            {
                txtDepartment.Items.Add(department.Name);
            }
        }
    }
}

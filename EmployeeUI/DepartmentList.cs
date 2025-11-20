using DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class DepartmentList : Form
    {
        public DepartmentList()
        {
            InitializeComponent();
        }

        private void DepartmentList_Load(object sender, EventArgs e)
        {
            EmployeeDbContext context = new EmployeeDbContext();
            var result = context.Departments.ToList();

            dgwDepartmentList.DataSource = result;
        }
    }
}

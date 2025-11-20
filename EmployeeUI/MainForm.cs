namespace EmployeeUI
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        bool menuExpand = false;
        bool menuExpandDepartment = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                panelEmployee.Height += 10;
                if (panelEmployee.Height >= 185)
                {
                    transitionEmployee.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelEmployee.Height -= 10;
                if (panelEmployee.Height <= 60)
                {
                    transitionEmployee.Stop();
                    menuExpand = false;
                }
            }
        }

        private void transitionDepartment_Tick(object sender, EventArgs e)
        {
            if (!menuExpandDepartment)
            {
                panelDepartment.Height += 10;
                if (panelDepartment.Height >= 185)
                {
                    transitionDepartment.Stop();
                    menuExpandDepartment = true;
                }
            }
            else
            {
                panelDepartment.Height -= 10;
                if (panelDepartment.Height <= 60)
                {
                    transitionDepartment.Stop();
                    menuExpandDepartment = false;
                }
            }
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            transitionDepartment.Start();
            //ActivateButton(sender);
            
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            transitionEmployee.Start();
            //ActivateButton(sender);
            
        }

        private void btnListDepartment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DepartmentList(), sender);
        }

        private void btnSaveDepartment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Department(), sender);
        }

        private void btnListEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeForm(), sender);
        }
    }
}

namespace EmployeeUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDepartment = new Button();
            btnEmployee = new Button();
            tabPage2 = new TabPage();
            button2 = new Button();
            panelMenu = new Panel();
            button3 = new Button();
            button1 = new Button();
            btnMainEmployee = new Button();
            panelLogo = new Panel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(730, 307);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(455, 181);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDepartment);
            tabPage1.Controls.Add(btnEmployee);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(447, 148);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kayıt";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDepartment
            // 
            btnDepartment.Location = new Point(6, 42);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(150, 30);
            btnDepartment.TabIndex = 1;
            btnDepartment.Text = "Personel Bölümleri";
            btnDepartment.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(6, 6);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(150, 30);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Personel Listesi";
            btnEmployee.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(447, 148);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 6);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnMainEmployee);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 550);
            panelMenu.TabIndex = 1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Gainsboro;
            button3.Image = Properties.Resources.Employee;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 200);
            button3.Name = "button3";
            button3.Padding = new Padding(12, 0, 0, 0);
            button3.Size = new Size(220, 60);
            button3.TabIndex = 3;
            button3.Text = "Employee";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Image = Properties.Resources.Employee;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 140);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(220, 60);
            button1.TabIndex = 2;
            button1.Text = "Employee";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnMainEmployee
            // 
            btnMainEmployee.Dock = DockStyle.Top;
            btnMainEmployee.FlatAppearance.BorderSize = 0;
            btnMainEmployee.FlatStyle = FlatStyle.Flat;
            btnMainEmployee.ForeColor = Color.Gainsboro;
            btnMainEmployee.Image = Properties.Resources.Employee;
            btnMainEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnMainEmployee.Location = new Point(0, 80);
            btnMainEmployee.Name = "btnMainEmployee";
            btnMainEmployee.Padding = new Padding(12, 0, 0, 0);
            btnMainEmployee.Size = new Size(220, 60);
            btnMainEmployee.TabIndex = 1;
            btnMainEmployee.Text = "Employee";
            btnMainEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnMainEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMainEmployee.UseVisualStyleBackColor = true;
            btnMainEmployee.Click += btnMainEmployee_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 550);
            Controls.Add(panelMenu);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Takip Formu";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnEmployee;
        private Button button2;
        private Button btnDepartment;
        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnMainEmployee;
        private Button button3;
        private Button button1;
    }
}

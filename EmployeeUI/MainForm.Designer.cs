namespace EmployeeUI
{
    partial class MainForm
    {
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelLogo = new Panel();
            label1 = new Label();
            panelDepartment = new FlowLayoutPanel();
            btnDepartment = new Button();
            btnListDepartment = new Button();
            btnSaveDepartment = new Button();
            panelEmployee = new FlowLayoutPanel();
            btnEmployee = new Button();
            btnListEmployee = new Button();
            btnSaveEmployee = new Button();
            panelTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelMenu = new FlowLayoutPanel();
            transitionEmployee = new System.Windows.Forms.Timer(components);
            transitionDepartment = new System.Windows.Forms.Timer(components);
            sidebarEmployee = new System.Windows.Forms.Timer(components);
            panelLogo.SuspendLayout();
            panelDepartment.SuspendLayout();
            panelEmployee.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Program";
            // 
            // panelDepartment
            // 
            panelDepartment.Controls.Add(btnDepartment);
            panelDepartment.Controls.Add(btnListDepartment);
            panelDepartment.Controls.Add(btnSaveDepartment);
            panelDepartment.Location = new Point(0, 80);
            panelDepartment.Margin = new Padding(0);
            panelDepartment.Name = "panelDepartment";
            panelDepartment.Size = new Size(220, 60);
            panelDepartment.TabIndex = 2;
            // 
            // btnDepartment
            // 
            btnDepartment.Dock = DockStyle.Top;
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.ForeColor = Color.Gainsboro;
            btnDepartment.Image = (Image)resources.GetObject("btnDepartment.Image");
            btnDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            btnDepartment.Location = new Point(3, 3);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Padding = new Padding(12, 0, 0, 0);
            btnDepartment.Size = new Size(220, 60);
            btnDepartment.TabIndex = 3;
            btnDepartment.Text = "Bölüm";
            btnDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDepartment.UseVisualStyleBackColor = true;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnListDepartment
            // 
            btnListDepartment.Dock = DockStyle.Top;
            btnListDepartment.FlatAppearance.BorderSize = 0;
            btnListDepartment.FlatStyle = FlatStyle.Flat;
            btnListDepartment.ForeColor = Color.Gainsboro;
            btnListDepartment.Image = (Image)resources.GetObject("btnListDepartment.Image");
            btnListDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            btnListDepartment.Location = new Point(3, 69);
            btnListDepartment.Name = "btnListDepartment";
            btnListDepartment.Padding = new Padding(12, 0, 0, 0);
            btnListDepartment.Size = new Size(220, 60);
            btnListDepartment.TabIndex = 5;
            btnListDepartment.Text = "Bölüm Listesi";
            btnListDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnListDepartment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListDepartment.UseVisualStyleBackColor = true;
            btnListDepartment.Click += btnListDepartment_Click;
            // 
            // btnSaveDepartment
            // 
            btnSaveDepartment.Dock = DockStyle.Top;
            btnSaveDepartment.FlatAppearance.BorderSize = 0;
            btnSaveDepartment.FlatStyle = FlatStyle.Flat;
            btnSaveDepartment.ForeColor = Color.Gainsboro;
            btnSaveDepartment.Image = (Image)resources.GetObject("btnSaveDepartment.Image");
            btnSaveDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveDepartment.Location = new Point(3, 135);
            btnSaveDepartment.Name = "btnSaveDepartment";
            btnSaveDepartment.Padding = new Padding(12, 0, 0, 0);
            btnSaveDepartment.Size = new Size(220, 60);
            btnSaveDepartment.TabIndex = 4;
            btnSaveDepartment.Text = "Bölüm Ekle";
            btnSaveDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnSaveDepartment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveDepartment.UseVisualStyleBackColor = true;
            btnSaveDepartment.Click += btnSaveDepartment_Click;
            // 
            // panelEmployee
            // 
            panelEmployee.Controls.Add(btnEmployee);
            panelEmployee.Controls.Add(btnListEmployee);
            panelEmployee.Controls.Add(btnSaveEmployee);
            panelEmployee.Location = new Point(0, 140);
            panelEmployee.Margin = new Padding(0);
            panelEmployee.Name = "panelEmployee";
            panelEmployee.Size = new Size(220, 60);
            panelEmployee.TabIndex = 1;
            // 
            // btnEmployee
            // 
            btnEmployee.Dock = DockStyle.Top;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.ForeColor = Color.Gainsboro;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(3, 3);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(12, 0, 0, 0);
            btnEmployee.Size = new Size(220, 60);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "Personel";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnListEmployee
            // 
            btnListEmployee.Dock = DockStyle.Top;
            btnListEmployee.FlatAppearance.BorderSize = 0;
            btnListEmployee.FlatStyle = FlatStyle.Flat;
            btnListEmployee.ForeColor = Color.Gainsboro;
            btnListEmployee.Image = (Image)resources.GetObject("btnListEmployee.Image");
            btnListEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnListEmployee.Location = new Point(3, 69);
            btnListEmployee.Name = "btnListEmployee";
            btnListEmployee.Padding = new Padding(12, 0, 0, 0);
            btnListEmployee.Size = new Size(220, 60);
            btnListEmployee.TabIndex = 4;
            btnListEmployee.Text = "Personel Listesi";
            btnListEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnListEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListEmployee.UseVisualStyleBackColor = true;
            btnListEmployee.Click += btnListEmployee_Click;
            // 
            // btnSaveEmployee
            // 
            btnSaveEmployee.Dock = DockStyle.Top;
            btnSaveEmployee.FlatAppearance.BorderSize = 0;
            btnSaveEmployee.FlatStyle = FlatStyle.Flat;
            btnSaveEmployee.ForeColor = Color.Gainsboro;
            btnSaveEmployee.Image = (Image)resources.GetObject("btnSaveEmployee.Image");
            btnSaveEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveEmployee.Location = new Point(3, 135);
            btnSaveEmployee.Name = "btnSaveEmployee";
            btnSaveEmployee.Padding = new Padding(12, 0, 0, 0);
            btnSaveEmployee.Size = new Size(220, 60);
            btnSaveEmployee.TabIndex = 3;
            btnSaveEmployee.Text = "Personel Ekle";
            btnSaveEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnSaveEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveEmployee.UseVisualStyleBackColor = true;
            btnSaveEmployee.Click += btnSaveEmployee_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(980, 80);
            panelTitleBar.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(945, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 3;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(910, 10);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.TabIndex = 2;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(875, 10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(430, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(88, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(220, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(980, 470);
            panelDesktopPane.TabIndex = 3;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(panelDepartment);
            panelMenu.Controls.Add(panelEmployee);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 550);
            panelMenu.TabIndex = 1;
            // 
            // transitionEmployee
            // 
            transitionEmployee.Interval = 5;
            transitionEmployee.Tick += menuTransition_Tick;
            // 
            // transitionDepartment
            // 
            transitionDepartment.Interval = 5;
            transitionDepartment.Tick += transitionDepartment_Tick;
            // 
            // sidebarEmployee
            // 
            sidebarEmployee.Interval = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 550);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Takip Formu";
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelDepartment.ResumeLayout(false);
            panelEmployee.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLogo;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPane;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Button btnListEmployee;
        private Button btnSaveEmployee;
        private Button btnEmployee;
        private System.Windows.Forms.Timer transitionEmployee;
        private Button btnListDepartment;
        private Button btnSaveDepartment;
        private Button btnDepartment;
        private System.Windows.Forms.Timer transitionDepartment;
        private System.Windows.Forms.Timer sidebarEmployee;
        private FlowLayoutPanel panelEmployee;
        private FlowLayoutPanel panelDepartment;
        private FlowLayoutPanel panelMenu;
    }
}

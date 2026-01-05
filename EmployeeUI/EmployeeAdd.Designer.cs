namespace EmployeeUI
{
    partial class EmployeeAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEmployee = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpBirthDate = new DateTimePicker();
            dtpStartingDate = new DateTimePicker();
            txtSalary = new NumericUpDown();
            txtDepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtSalary).BeginInit();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(20, 220);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(300, 29);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Personel Ekle";
            btnEmployee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Personel Adı";
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(140, 27);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 50);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 3;
            label2.Text = "Personel Soyadı";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(180, 50);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(140, 27);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 80);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 5;
            label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 110);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "Maaş";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 140);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 9;
            label5.Text = "İşe Başlama Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 170);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 11;
            label6.Text = "Bölüm";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(180, 80);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(140, 27);
            dtpBirthDate.TabIndex = 13;
            // 
            // dtpStartingDate
            // 
            dtpStartingDate.Location = new Point(180, 140);
            dtpStartingDate.Name = "dtpStartingDate";
            dtpStartingDate.Size = new Size(140, 27);
            dtpStartingDate.TabIndex = 14;
            // 
            // txtSalary
            // 
            txtSalary.DecimalPlaces = 2;
            txtSalary.Location = new Point(180, 110);
            txtSalary.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(140, 27);
            txtSalary.TabIndex = 15;
            // 
            // txtDepartment
            // 
            txtDepartment.DropDownHeight = 100;
            txtDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDepartment.DropDownWidth = 150;
            txtDepartment.FormattingEnabled = true;
            txtDepartment.IntegralHeight = false;
            txtDepartment.Location = new Point(180, 170);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(140, 28);
            txtDepartment.TabIndex = 16;
            // 
            // EmployeeAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 271);
            Controls.Add(txtDepartment);
            Controls.Add(txtSalary);
            Controls.Add(dtpStartingDate);
            Controls.Add(dtpBirthDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnEmployee);
            Name = "EmployeeAdd";
            Text = "Personel Ekleme Formu";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)txtSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmployee;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpBirthDate;
        private DateTimePicker dtpStartingDate;
        private NumericUpDown txtSalary;
        private ComboBox txtDepartment;
    }
}
namespace EmployeeUI
{
    partial class EmployeeForm
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
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(12, 409);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(141, 29);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Personel Listesi";
            btnEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEmployee);
            Name = "EmployeeForm";
            Text = "Form2";
            Load += EmployeeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployee;
    }
}
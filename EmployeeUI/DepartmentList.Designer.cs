namespace EmployeeUI
{
    partial class DepartmentList
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
            dgwDepartmentList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwDepartmentList).BeginInit();
            SuspendLayout();
            // 
            // dgwDepartmentList
            // 
            dgwDepartmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDepartmentList.BackgroundColor = Color.White;
            dgwDepartmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDepartmentList.Dock = DockStyle.Fill;
            dgwDepartmentList.Location = new Point(0, 0);
            dgwDepartmentList.Name = "dgwDepartmentList";
            dgwDepartmentList.RowHeadersWidth = 51;
            dgwDepartmentList.RowTemplate.Height = 29;
            dgwDepartmentList.Size = new Size(800, 450);
            dgwDepartmentList.TabIndex = 0;
            // 
            // DepartmentList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgwDepartmentList);
            Name = "DepartmentList";
            Text = "DepartmentList";
            Load += DepartmentList_Load;
            ((System.ComponentModel.ISupportInitialize)dgwDepartmentList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwDepartmentList;
    }
}
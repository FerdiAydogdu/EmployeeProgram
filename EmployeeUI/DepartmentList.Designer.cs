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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgwDepartmentList = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgwDepartmentList).BeginInit();
            SuspendLayout();
            // 
            // dgwDepartmentList
            // 
            dgwDepartmentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwDepartmentList.BackgroundColor = Color.White;
            dgwDepartmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDepartmentList.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colStatus, colDelete });
            dgwDepartmentList.Dock = DockStyle.Fill;
            dgwDepartmentList.Location = new Point(0, 0);
            dgwDepartmentList.Name = "dgwDepartmentList";
            dgwDepartmentList.RowHeadersWidth = 51;
            dgwDepartmentList.RowTemplate.Height = 29;
            dgwDepartmentList.Size = new Size(800, 450);
            dgwDepartmentList.TabIndex = 0;
            dgwDepartmentList.CellContentClick += dgwDepartmentList_CellContentClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Bölüm Adı";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Durum";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Red;
            colDelete.DefaultCellStyle = dataGridViewCellStyle1;
            colDelete.HeaderText = "Sil";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.Text = "X";
            colDelete.UseColumnTextForButtonValue = true;
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
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colDelete;
    }
}
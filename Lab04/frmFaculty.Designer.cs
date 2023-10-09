namespace Lab04
{
    partial class frmFaculty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btFacultyExit = new System.Windows.Forms.Button();
            this.btFacultyDelete = new System.Windows.Forms.Button();
            this.btFacultyReplace = new System.Windows.Forms.Button();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.FacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btFacultyAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalProfessor = new System.Windows.Forms.TextBox();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.lbTotalProfessor = new System.Windows.Forms.Label();
            this.lbFacultyName = new System.Windows.Forms.Label();
            this.lbFacultyID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFacultyExit
            // 
            this.btFacultyExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btFacultyExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFacultyExit.Location = new System.Drawing.Point(1062, 374);
            this.btFacultyExit.Name = "btFacultyExit";
            this.btFacultyExit.Size = new System.Drawing.Size(95, 35);
            this.btFacultyExit.TabIndex = 20;
            this.btFacultyExit.Text = "Thoát";
            this.btFacultyExit.UseVisualStyleBackColor = true;
            this.btFacultyExit.Click += new System.EventHandler(this.btFacultyExit_Click);
            // 
            // btFacultyDelete
            // 
            this.btFacultyDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFacultyDelete.Location = new System.Drawing.Point(323, 335);
            this.btFacultyDelete.Name = "btFacultyDelete";
            this.btFacultyDelete.Size = new System.Drawing.Size(95, 35);
            this.btFacultyDelete.TabIndex = 19;
            this.btFacultyDelete.Text = "Xóa";
            this.btFacultyDelete.UseVisualStyleBackColor = true;
            this.btFacultyDelete.Click += new System.EventHandler(this.btFacultyDelete_Click);
            // 
            // btFacultyReplace
            // 
            this.btFacultyReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFacultyReplace.Location = new System.Drawing.Point(225, 335);
            this.btFacultyReplace.Name = "btFacultyReplace";
            this.btFacultyReplace.Size = new System.Drawing.Size(95, 35);
            this.btFacultyReplace.TabIndex = 18;
            this.btFacultyReplace.Text = "Sửa";
            this.btFacultyReplace.UseVisualStyleBackColor = true;
            this.btFacultyReplace.Click += new System.EventHandler(this.btFacultyReplace_Click);
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.AllowUserToAddRows = false;
            this.dgvFaculty.AllowUserToDeleteRows = false;
            this.dgvFaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFaculty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FacultyID,
            this.FacultyName,
            this.TotalProfessor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFaculty.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFaculty.Location = new System.Drawing.Point(437, 63);
            this.dgvFaculty.MultiSelect = false;
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.ReadOnly = true;
            this.dgvFaculty.RowHeadersWidth = 51;
            this.dgvFaculty.RowTemplate.Height = 24;
            this.dgvFaculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFaculty.Size = new System.Drawing.Size(720, 310);
            this.dgvFaculty.TabIndex = 17;
            this.dgvFaculty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculty_CellClick);
            // 
            // FacultyID
            // 
            this.FacultyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacultyID.HeaderText = "Mã Khoa";
            this.FacultyID.MinimumWidth = 6;
            this.FacultyID.Name = "FacultyID";
            this.FacultyID.ReadOnly = true;
            // 
            // FacultyName
            // 
            this.FacultyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacultyName.HeaderText = "Tên Khoa";
            this.FacultyName.MinimumWidth = 6;
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.ReadOnly = true;
            // 
            // TotalProfessor
            // 
            this.TotalProfessor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalProfessor.HeaderText = "Tổng số GS";
            this.TotalProfessor.MinimumWidth = 6;
            this.TotalProfessor.Name = "TotalProfessor";
            this.TotalProfessor.ReadOnly = true;
            // 
            // btFacultyAdd
            // 
            this.btFacultyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFacultyAdd.Location = new System.Drawing.Point(125, 335);
            this.btFacultyAdd.Name = "btFacultyAdd";
            this.btFacultyAdd.Size = new System.Drawing.Size(95, 35);
            this.btFacultyAdd.TabIndex = 16;
            this.btFacultyAdd.Text = "Thêm";
            this.btFacultyAdd.UseVisualStyleBackColor = true;
            this.btFacultyAdd.Click += new System.EventHandler(this.btFacultyAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotalProfessor);
            this.panel1.Controls.Add(this.txtFacultyName);
            this.panel1.Controls.Add(this.txtFacultyID);
            this.panel1.Controls.Add(this.lbTotalProfessor);
            this.panel1.Controls.Add(this.lbFacultyName);
            this.panel1.Controls.Add(this.lbFacultyID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(26, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 265);
            this.panel1.TabIndex = 15;
            // 
            // txtTotalProfessor
            // 
            this.txtTotalProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProfessor.Location = new System.Drawing.Point(145, 111);
            this.txtTotalProfessor.Name = "txtTotalProfessor";
            this.txtTotalProfessor.Size = new System.Drawing.Size(160, 28);
            this.txtTotalProfessor.TabIndex = 9;
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyName.Location = new System.Drawing.Point(145, 77);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(242, 28);
            this.txtFacultyName.TabIndex = 8;
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacultyID.Location = new System.Drawing.Point(145, 43);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(160, 28);
            this.txtFacultyID.TabIndex = 7;
            // 
            // lbTotalProfessor
            // 
            this.lbTotalProfessor.AutoSize = true;
            this.lbTotalProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalProfessor.Location = new System.Drawing.Point(21, 113);
            this.lbTotalProfessor.Name = "lbTotalProfessor";
            this.lbTotalProfessor.Size = new System.Drawing.Size(118, 25);
            this.lbTotalProfessor.TabIndex = 5;
            this.lbTotalProfessor.Text = "Tổng số GS";
            // 
            // lbFacultyName
            // 
            this.lbFacultyName.AutoSize = true;
            this.lbFacultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacultyName.Location = new System.Drawing.Point(21, 81);
            this.lbFacultyName.Name = "lbFacultyName";
            this.lbFacultyName.Size = new System.Drawing.Size(95, 25);
            this.lbFacultyName.TabIndex = 3;
            this.lbFacultyName.Text = "Tên khoa";
            // 
            // lbFacultyID
            // 
            this.lbFacultyID.AutoSize = true;
            this.lbFacultyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacultyID.Location = new System.Drawing.Point(21, 46);
            this.lbFacultyID.Name = "lbFacultyID";
            this.lbFacultyID.Size = new System.Drawing.Size(88, 25);
            this.lbFacultyID.TabIndex = 2;
            this.lbFacultyID.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin khoa";
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btFacultyExit;
            this.ClientSize = new System.Drawing.Size(1182, 473);
            this.Controls.Add(this.btFacultyExit);
            this.Controls.Add(this.btFacultyDelete);
            this.Controls.Add(this.btFacultyReplace);
            this.Controls.Add(this.dgvFaculty);
            this.Controls.Add(this.btFacultyAdd);
            this.Controls.Add(this.panel1);
            this.Name = "frmFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFaculty";
            this.Load += new System.EventHandler(this.frmFaculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFacultyExit;
        private System.Windows.Forms.Button btFacultyDelete;
        private System.Windows.Forms.Button btFacultyReplace;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.Button btFacultyAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalProfessor;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.Label lbTotalProfessor;
        private System.Windows.Forms.Label lbFacultyName;
        private System.Windows.Forms.Label lbFacultyID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProfessor;
    }
}
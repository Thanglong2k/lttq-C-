namespace GUI.FORMS.FORM_IN_Sản_phẩm.FORM_IN_Chi_tiết
{
    partial class FormCongViec
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewCV = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkMaCV = new System.Windows.Forms.Label();
            this.checkTenCV = new System.Windows.Forms.Label();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCV
            // 
            this.dataGridViewCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV});
            this.dataGridViewCV.Location = new System.Drawing.Point(12, 205);
            this.dataGridViewCV.Name = "dataGridViewCV";
            this.dataGridViewCV.RowHeadersWidth = 51;
            this.dataGridViewCV.RowTemplate.Height = 24;
            this.dataGridViewCV.Size = new System.Drawing.Size(696, 183);
            this.dataGridViewCV.TabIndex = 101;
            this.dataGridViewCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCV_CellClick);
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã công việc";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            this.MaCV.Width = 125;
            // 
            // TenCV
            // 
            this.TenCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên công việc";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            this.TenCV.ReadOnly = true;
            // 
            // checkMaCV
            // 
            this.checkMaCV.AutoSize = true;
            this.checkMaCV.Location = new System.Drawing.Point(455, 49);
            this.checkMaCV.Name = "checkMaCV";
            this.checkMaCV.Size = new System.Drawing.Size(38, 17);
            this.checkMaCV.TabIndex = 99;
            this.checkMaCV.Text = "lable";
            // 
            // checkTenCV
            // 
            this.checkTenCV.AutoSize = true;
            this.checkTenCV.Location = new System.Drawing.Point(455, 113);
            this.checkTenCV.Name = "checkTenCV";
            this.checkTenCV.Size = new System.Drawing.Size(38, 17);
            this.checkTenCV.TabIndex = 100;
            this.checkTenCV.Text = "lable";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCV.Location = new System.Drawing.Point(127, 106);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(322, 29);
            this.txtTenCV.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 97;
            this.label6.Text = "Tên công việc:";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCV.Location = new System.Drawing.Point(127, 43);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(322, 29);
            this.txtMaCV.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 95;
            this.label9.Text = "Mã công việc:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(569, 140);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 34);
            this.btnXoa.TabIndex = 94;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(569, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 34);
            this.btnThem.TabIndex = 93;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(569, 91);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 34);
            this.btnSua.TabIndex = 102;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 405);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridViewCV);
            this.Controls.Add(this.checkMaCV);
            this.Controls.Add(this.checkTenCV);
            this.Controls.Add(this.txtTenCV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCongViec";
            this.Text = "FormCongViec";
            this.Load += new System.EventHandler(this.FormCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCV;
        private System.Windows.Forms.Label checkMaCV;
        private System.Windows.Forms.Label checkTenCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
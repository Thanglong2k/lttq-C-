namespace GUI.FORMS.FORM_IN_Sản_phẩm.FORM_IN_Chi_tiết
{
    partial class FormNuocSX
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
            this.dataGridViewNSX = new System.Windows.Forms.DataGridView();
            this.manuocsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennuocsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkMaNSX = new System.Windows.Forms.Label();
            this.checkTenNSX = new System.Windows.Forms.Label();
            this.txtTenNuocSX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNuocSX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNSX)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNSX
            // 
            this.dataGridViewNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manuocsx,
            this.tennuocsx});
            this.dataGridViewNSX.Location = new System.Drawing.Point(12, 194);
            this.dataGridViewNSX.Name = "dataGridViewNSX";
            this.dataGridViewNSX.RowHeadersWidth = 51;
            this.dataGridViewNSX.RowTemplate.Height = 24;
            this.dataGridViewNSX.Size = new System.Drawing.Size(696, 183);
            this.dataGridViewNSX.TabIndex = 92;
            this.dataGridViewNSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNSX_CellClick);
            // 
            // manuocsx
            // 
            this.manuocsx.DataPropertyName = "MaNSX";
            this.manuocsx.HeaderText = "Mã nước SX";
            this.manuocsx.MinimumWidth = 6;
            this.manuocsx.Name = "manuocsx";
            this.manuocsx.ReadOnly = true;
            this.manuocsx.Width = 125;
            // 
            // tennuocsx
            // 
            this.tennuocsx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tennuocsx.DataPropertyName = "TenNSX";
            this.tennuocsx.HeaderText = "Tên nước SX";
            this.tennuocsx.MinimumWidth = 6;
            this.tennuocsx.Name = "tennuocsx";
            this.tennuocsx.ReadOnly = true;
            // 
            // checkMaNSX
            // 
            this.checkMaNSX.AutoSize = true;
            this.checkMaNSX.Location = new System.Drawing.Point(450, 50);
            this.checkMaNSX.Name = "checkMaNSX";
            this.checkMaNSX.Size = new System.Drawing.Size(38, 17);
            this.checkMaNSX.TabIndex = 90;
            this.checkMaNSX.Text = "lable";
            // 
            // checkTenNSX
            // 
            this.checkTenNSX.AutoSize = true;
            this.checkTenNSX.Location = new System.Drawing.Point(450, 117);
            this.checkTenNSX.Name = "checkTenNSX";
            this.checkTenNSX.Size = new System.Drawing.Size(38, 17);
            this.checkTenNSX.TabIndex = 91;
            this.checkTenNSX.Text = "lable";
            // 
            // txtTenNuocSX
            // 
            this.txtTenNuocSX.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNuocSX.Location = new System.Drawing.Point(118, 110);
            this.txtTenNuocSX.Name = "txtTenNuocSX";
            this.txtTenNuocSX.Size = new System.Drawing.Size(326, 29);
            this.txtTenNuocSX.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 88;
            this.label6.Text = "Tên nước SX:";
            // 
            // txtMaNuocSX
            // 
            this.txtMaNuocSX.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNuocSX.Location = new System.Drawing.Point(118, 45);
            this.txtMaNuocSX.Name = "txtMaNuocSX";
            this.txtMaNuocSX.Size = new System.Drawing.Size(326, 29);
            this.txtMaNuocSX.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 86;
            this.label9.Text = "Mã nước SX:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(568, 130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 34);
            this.btnXoa.TabIndex = 85;
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
            this.btnThem.Location = new System.Drawing.Point(568, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 34);
            this.btnThem.TabIndex = 84;
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
            this.btnSua.Location = new System.Drawing.Point(568, 86);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 34);
            this.btnSua.TabIndex = 93;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormNuocSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(719, 422);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridViewNSX);
            this.Controls.Add(this.checkMaNSX);
            this.Controls.Add(this.checkTenNSX);
            this.Controls.Add(this.txtTenNuocSX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaNuocSX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuocSX";
            this.Text = "FormNuocSX";
            this.Load += new System.EventHandler(this.FormNuocSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNSX;
        private System.Windows.Forms.Label checkMaNSX;
        private System.Windows.Forms.Label checkTenNSX;
        private System.Windows.Forms.TextBox txtTenNuocSX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNuocSX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn manuocsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennuocsx;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
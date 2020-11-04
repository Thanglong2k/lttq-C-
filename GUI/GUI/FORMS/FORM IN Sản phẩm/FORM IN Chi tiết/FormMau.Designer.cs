namespace GUI.FORMS.FORM_IN_Sản_phẩm.FORM_IN_Chi_tiết
{
    partial class FormMau
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
            this.dataGridViewMau = new System.Windows.Forms.DataGridView();
            this.mamau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkMaMau = new System.Windows.Forms.Label();
            this.checkMau = new System.Windows.Forms.Label();
            this.txtTenMau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaMau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMau)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMau
            // 
            this.dataGridViewMau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamau,
            this.tenmau});
            this.dataGridViewMau.Location = new System.Drawing.Point(12, 206);
            this.dataGridViewMau.Name = "dataGridViewMau";
            this.dataGridViewMau.RowHeadersWidth = 51;
            this.dataGridViewMau.RowTemplate.Height = 24;
            this.dataGridViewMau.Size = new System.Drawing.Size(696, 183);
            this.dataGridViewMau.TabIndex = 83;
            this.dataGridViewMau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMau_CellClick);
            // 
            // mamau
            // 
            this.mamau.DataPropertyName = "MaMau";
            this.mamau.HeaderText = "Mã màu";
            this.mamau.MinimumWidth = 6;
            this.mamau.Name = "mamau";
            this.mamau.ReadOnly = true;
            this.mamau.Width = 125;
            // 
            // tenmau
            // 
            this.tenmau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenmau.DataPropertyName = "TenMau";
            this.tenmau.HeaderText = "Tên màu";
            this.tenmau.MinimumWidth = 6;
            this.tenmau.Name = "tenmau";
            this.tenmau.ReadOnly = true;
            // 
            // checkMaMau
            // 
            this.checkMaMau.AutoSize = true;
            this.checkMaMau.Location = new System.Drawing.Point(444, 51);
            this.checkMaMau.Name = "checkMaMau";
            this.checkMaMau.Size = new System.Drawing.Size(38, 17);
            this.checkMaMau.TabIndex = 81;
            this.checkMaMau.Text = "lable";
            // 
            // checkMau
            // 
            this.checkMau.AutoSize = true;
            this.checkMau.Location = new System.Drawing.Point(444, 115);
            this.checkMau.Name = "checkMau";
            this.checkMau.Size = new System.Drawing.Size(38, 17);
            this.checkMau.TabIndex = 82;
            this.checkMau.Text = "lable";
            // 
            // txtTenMau
            // 
            this.txtTenMau.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMau.Location = new System.Drawing.Point(90, 108);
            this.txtTenMau.Name = "txtTenMau";
            this.txtTenMau.Size = new System.Drawing.Size(348, 29);
            this.txtTenMau.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "Tên màu:";
            // 
            // txtMaMau
            // 
            this.txtMaMau.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMau.Location = new System.Drawing.Point(90, 45);
            this.txtMaMau.Name = "txtMaMau";
            this.txtMaMau.Size = new System.Drawing.Size(348, 29);
            this.txtMaMau.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 18);
            this.label9.TabIndex = 77;
            this.label9.Text = "Mã màu:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(568, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 34);
            this.btnXoa.TabIndex = 76;
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
            this.btnThem.Location = new System.Drawing.Point(568, 43);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 34);
            this.btnThem.TabIndex = 75;
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
            this.btnSua.Location = new System.Drawing.Point(568, 94);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 34);
            this.btnSua.TabIndex = 84;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(719, 415);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridViewMau);
            this.Controls.Add(this.checkMaMau);
            this.Controls.Add(this.checkMau);
            this.Controls.Add(this.txtTenMau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaMau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMau";
            this.Text = "FormMau";
            this.Load += new System.EventHandler(this.FormMau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMau;
        private System.Windows.Forms.Label checkMaMau;
        private System.Windows.Forms.Label checkMau;
        private System.Windows.Forms.TextBox txtTenMau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaMau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamau;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmau;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
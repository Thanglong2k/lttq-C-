namespace GUI.FORMS.FORM_IN_Sản_phẩm.FORM_IN_Chi_tiết
{
    partial class FormCaLam
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
            this.dataGridViewCL = new System.Windows.Forms.DataGridView();
            this.maca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkMaCa = new System.Windows.Forms.Label();
            this.checkTenCa = new System.Windows.Forms.Label();
            this.txtTenCa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaCa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCL
            // 
            this.dataGridViewCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maca,
            this.tenca});
            this.dataGridViewCL.Location = new System.Drawing.Point(12, 221);
            this.dataGridViewCL.Name = "dataGridViewCL";
            this.dataGridViewCL.RowHeadersWidth = 51;
            this.dataGridViewCL.RowTemplate.Height = 24;
            this.dataGridViewCL.Size = new System.Drawing.Size(696, 183);
            this.dataGridViewCL.TabIndex = 92;
            this.dataGridViewCL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCL_CellClick);
            // 
            // maca
            // 
            this.maca.DataPropertyName = "MaCa";
            this.maca.HeaderText = "Mã ca";
            this.maca.MinimumWidth = 6;
            this.maca.Name = "maca";
            this.maca.ReadOnly = true;
            this.maca.Width = 125;
            // 
            // tenca
            // 
            this.tenca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenca.DataPropertyName = "TenCa";
            this.tenca.HeaderText = "Tên ca";
            this.tenca.MinimumWidth = 6;
            this.tenca.Name = "tenca";
            this.tenca.ReadOnly = true;
            // 
            // checkMaCa
            // 
            this.checkMaCa.AutoSize = true;
            this.checkMaCa.Location = new System.Drawing.Point(418, 50);
            this.checkMaCa.Name = "checkMaCa";
            this.checkMaCa.Size = new System.Drawing.Size(38, 17);
            this.checkMaCa.TabIndex = 90;
            this.checkMaCa.Text = "lable";
            // 
            // checkTenCa
            // 
            this.checkTenCa.AutoSize = true;
            this.checkTenCa.Location = new System.Drawing.Point(418, 110);
            this.checkTenCa.Name = "checkTenCa";
            this.checkTenCa.Size = new System.Drawing.Size(38, 17);
            this.checkTenCa.TabIndex = 91;
            this.checkTenCa.Text = "lable";
            // 
            // txtTenCa
            // 
            this.txtTenCa.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCa.Location = new System.Drawing.Point(90, 103);
            this.txtTenCa.Name = "txtTenCa";
            this.txtTenCa.Size = new System.Drawing.Size(322, 29);
            this.txtTenCa.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 88;
            this.label6.Text = "Tên ca:";
            // 
            // txtMaCa
            // 
            this.txtMaCa.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCa.Location = new System.Drawing.Point(90, 44);
            this.txtMaCa.Name = "txtMaCa";
            this.txtMaCa.Size = new System.Drawing.Size(322, 29);
            this.txtMaCa.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 86;
            this.label9.Text = "Mã ca:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(568, 135);
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
            this.btnThem.Location = new System.Drawing.Point(568, 39);
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
            // FormCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(719, 426);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dataGridViewCL);
            this.Controls.Add(this.checkMaCa);
            this.Controls.Add(this.checkTenCa);
            this.Controls.Add(this.txtTenCa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaCa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCaLam";
            this.Text = "FormCaLam";
            this.Load += new System.EventHandler(this.FormCaLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCL;
        private System.Windows.Forms.Label checkMaCa;
        private System.Windows.Forms.Label checkTenCa;
        private System.Windows.Forms.TextBox txtTenCa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaCa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn maca;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenca;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
namespace GUI.FORMS
{
    partial class FormKH
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
            this.checkMaKhach = new System.Windows.Forms.Label();
            this.checkTenKhach = new System.Windows.Forms.Label();
            this.checkDC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaHDB = new System.Windows.Forms.Button();
            this.btnSuaHDB = new System.Windows.Forms.Button();
            this.btnThemHDB = new System.Windows.Forms.Button();
            this.dataGridViewKH = new System.Windows.Forms.DataGridView();
            this.MaKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.checkDT = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // checkMaKhach
            // 
            this.checkMaKhach.AutoSize = true;
            this.checkMaKhach.Location = new System.Drawing.Point(315, 41);
            this.checkMaKhach.Name = "checkMaKhach";
            this.checkMaKhach.Size = new System.Drawing.Size(38, 17);
            this.checkMaKhach.TabIndex = 88;
            this.checkMaKhach.Text = "lable";
            // 
            // checkTenKhach
            // 
            this.checkTenKhach.AutoSize = true;
            this.checkTenKhach.Location = new System.Drawing.Point(423, 93);
            this.checkTenKhach.Name = "checkTenKhach";
            this.checkTenKhach.Size = new System.Drawing.Size(38, 17);
            this.checkTenKhach.TabIndex = 87;
            this.checkTenKhach.Text = "lable";
            // 
            // checkDC
            // 
            this.checkDC.AutoSize = true;
            this.checkDC.Location = new System.Drawing.Point(504, 193);
            this.checkDC.Name = "checkDC";
            this.checkDC.Size = new System.Drawing.Size(38, 17);
            this.checkDC.TabIndex = 86;
            this.checkDC.Text = "lable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 83;
            this.label5.Text = "Địa Chỉ:";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.Location = new System.Drawing.Point(132, 86);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(285, 29);
            this.txtTenKhach.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "Tên Khách:";
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhach.Location = new System.Drawing.Point(132, 35);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(177, 29);
            this.txtMaKhach.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mã Khách:";
            // 
            // btnXoaHDB
            // 
            this.btnXoaHDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaHDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnXoaHDB.FlatAppearance.BorderSize = 0;
            this.btnXoaHDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHDB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHDB.ForeColor = System.Drawing.Color.White;
            this.btnXoaHDB.Location = new System.Drawing.Point(1004, 141);
            this.btnXoaHDB.Name = "btnXoaHDB";
            this.btnXoaHDB.Size = new System.Drawing.Size(221, 49);
            this.btnXoaHDB.TabIndex = 71;
            this.btnXoaHDB.Text = "Xóa";
            this.btnXoaHDB.UseVisualStyleBackColor = false;
            this.btnXoaHDB.Click += new System.EventHandler(this.btnXoaHDB_Click);
            // 
            // btnSuaHDB
            // 
            this.btnSuaHDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaHDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnSuaHDB.FlatAppearance.BorderSize = 0;
            this.btnSuaHDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHDB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHDB.ForeColor = System.Drawing.Color.White;
            this.btnSuaHDB.Location = new System.Drawing.Point(1004, 86);
            this.btnSuaHDB.Name = "btnSuaHDB";
            this.btnSuaHDB.Size = new System.Drawing.Size(221, 49);
            this.btnSuaHDB.TabIndex = 72;
            this.btnSuaHDB.Text = "Sửa";
            this.btnSuaHDB.UseVisualStyleBackColor = false;
            this.btnSuaHDB.Click += new System.EventHandler(this.btnSuaHDB_Click);
            // 
            // btnThemHDB
            // 
            this.btnThemHDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemHDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnThemHDB.FlatAppearance.BorderSize = 0;
            this.btnThemHDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHDB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHDB.ForeColor = System.Drawing.Color.White;
            this.btnThemHDB.Location = new System.Drawing.Point(1004, 31);
            this.btnThemHDB.Name = "btnThemHDB";
            this.btnThemHDB.Size = new System.Drawing.Size(221, 49);
            this.btnThemHDB.TabIndex = 70;
            this.btnThemHDB.Text = "Thêm";
            this.btnThemHDB.UseVisualStyleBackColor = false;
            this.btnThemHDB.Click += new System.EventHandler(this.btnThemHDB_Click);
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhach,
            this.TenKhach,
            this.DiaChi,
            this.DienThoai});
            this.dataGridViewKH.Location = new System.Drawing.Point(26, 265);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.ReadOnly = true;
            this.dataGridViewKH.RowHeadersWidth = 51;
            this.dataGridViewKH.RowTemplate.Height = 24;
            this.dataGridViewKH.Size = new System.Drawing.Size(1199, 416);
            this.dataGridViewKH.TabIndex = 69;
            this.dataGridViewKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_CellClick);
            // 
            // MaKhach
            // 
            this.MaKhach.DataPropertyName = "MaKH";
            this.MaKhach.HeaderText = "Mã Khách";
            this.MaKhach.MinimumWidth = 6;
            this.MaKhach.Name = "MaKhach";
            this.MaKhach.ReadOnly = true;
            this.MaKhach.Width = 150;
            // 
            // TenKhach
            // 
            this.TenKhach.DataPropertyName = "TenKH";
            this.TenKhach.HeaderText = "Tên Khách";
            this.TenKhach.MinimumWidth = 6;
            this.TenKhach.Name = "TenKhach";
            this.TenKhach.ReadOnly = true;
            this.TenKhach.Width = 286;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 125;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            this.DienThoai.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 83;
            this.label3.Text = "Điện Thoại:";
            // 
            // checkDT
            // 
            this.checkDT.AutoSize = true;
            this.checkDT.Location = new System.Drawing.Point(355, 141);
            this.checkDT.Name = "checkDT";
            this.checkDT.Size = new System.Drawing.Size(38, 17);
            this.checkDT.TabIndex = 88;
            this.checkDT.Text = "lable";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(134, 186);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(364, 29);
            this.txtDiaChi.TabIndex = 90;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(132, 135);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(217, 29);
            this.txtDienThoai.TabIndex = 89;
            // 
            // FormKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1251, 702);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.checkDT);
            this.Controls.Add(this.checkMaKhach);
            this.Controls.Add(this.checkTenKhach);
            this.Controls.Add(this.checkDC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaKhach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaHDB);
            this.Controls.Add(this.btnSuaHDB);
            this.Controls.Add(this.btnThemHDB);
            this.Controls.Add(this.dataGridViewKH);
            this.Name = "FormKH";
            this.Text = "FormKH";
            this.Load += new System.EventHandler(this.FormKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label checkMaKhach;
        private System.Windows.Forms.Label checkTenKhach;
        private System.Windows.Forms.Label checkDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaHDB;
        private System.Windows.Forms.Button btnSuaHDB;
        private System.Windows.Forms.Button btnThemHDB;
        private System.Windows.Forms.DataGridView dataGridViewKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label checkDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
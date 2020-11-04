namespace GUI
{
    partial class FormNV
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
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.cbCa = new System.Windows.Forms.ComboBox();
            this.cbCongViec = new System.Windows.Forms.ComboBox();
            this.checkMaNV = new System.Windows.Forms.Label();
            this.checkTenNV = new System.Windows.Forms.Label();
            this.checkDT = new System.Windows.Forms.Label();
            this.checkDiaChi = new System.Windows.Forms.Label();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.checkCongViec = new System.Windows.Forms.Label();
            this.checkCaLam = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.GioiTinh,
            this.NgaySinh,
            this.DienThoai,
            this.DiaChi,
            this.CaLam,
            this.CongViec});
            this.dataGridViewNV.Location = new System.Drawing.Point(26, 264);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.ReadOnly = true;
            this.dataGridViewNV.RowHeadersWidth = 51;
            this.dataGridViewNV.RowTemplate.Height = 24;
            this.dataGridViewNV.Size = new System.Drawing.Size(1399, 516);
            this.dataGridViewNV.TabIndex = 23;
            this.dataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 150;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 130;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            this.DienThoai.Width = 168;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 250;
            // 
            // CaLam
            // 
            this.CaLam.DataPropertyName = "MaCa";
            this.CaLam.HeaderText = "Ca Làm";
            this.CaLam.MinimumWidth = 6;
            this.CaLam.Name = "CaLam";
            this.CaLam.ReadOnly = true;
            this.CaLam.Width = 125;
            // 
            // CongViec
            // 
            this.CongViec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CongViec.DataPropertyName = "MaCV";
            this.CongViec.HeaderText = "Công Việc";
            this.CongViec.MinimumWidth = 6;
            this.CongViec.Name = "CongViec";
            this.CongViec.ReadOnly = true;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDienThoai.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(745, 30);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(221, 29);
            this.txtDienThoai.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Điện Thoại:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(650, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Công Việc:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(650, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ca Làm:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(745, 85);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(297, 29);
            this.txtDiaChi.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(650, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Giới Tính:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(130, 85);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(179, 29);
            this.txtTenNV.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(130, 30);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(177, 29);
            this.txtMaNV.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã NV:";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnXoaNV.FlatAppearance.BorderSize = 0;
            this.btnXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNV.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV.Location = new System.Drawing.Point(1298, 155);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(127, 46);
            this.btnXoaNV.TabIndex = 25;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnSuaNV.FlatAppearance.BorderSize = 0;
            this.btnSuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNV.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.ForeColor = System.Drawing.Color.White;
            this.btnSuaNV.Location = new System.Drawing.Point(1298, 92);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(127, 46);
            this.btnSuaNV.TabIndex = 26;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Location = new System.Drawing.Point(1298, 30);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(127, 46);
            this.btnThemNV.TabIndex = 24;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // cbCa
            // 
            this.cbCa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCa.BackColor = System.Drawing.SystemColors.Control;
            this.cbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCa.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCa.FormattingEnabled = true;
            this.cbCa.Location = new System.Drawing.Point(745, 138);
            this.cbCa.Name = "cbCa";
            this.cbCa.Size = new System.Drawing.Size(127, 28);
            this.cbCa.TabIndex = 45;
            // 
            // cbCongViec
            // 
            this.cbCongViec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCongViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCongViec.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCongViec.FormattingEnabled = true;
            this.cbCongViec.Location = new System.Drawing.Point(745, 191);
            this.cbCongViec.Name = "cbCongViec";
            this.cbCongViec.Size = new System.Drawing.Size(221, 28);
            this.cbCongViec.TabIndex = 46;
            // 
            // checkMaNV
            // 
            this.checkMaNV.AutoSize = true;
            this.checkMaNV.Location = new System.Drawing.Point(313, 36);
            this.checkMaNV.Name = "checkMaNV";
            this.checkMaNV.Size = new System.Drawing.Size(38, 17);
            this.checkMaNV.TabIndex = 48;
            this.checkMaNV.Text = "lable";
            // 
            // checkTenNV
            // 
            this.checkTenNV.AutoSize = true;
            this.checkTenNV.Location = new System.Drawing.Point(313, 92);
            this.checkTenNV.Name = "checkTenNV";
            this.checkTenNV.Size = new System.Drawing.Size(38, 17);
            this.checkTenNV.TabIndex = 48;
            this.checkTenNV.Text = "lable";
            // 
            // checkDT
            // 
            this.checkDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkDT.AutoSize = true;
            this.checkDT.Location = new System.Drawing.Point(972, 36);
            this.checkDT.Name = "checkDT";
            this.checkDT.Size = new System.Drawing.Size(38, 17);
            this.checkDT.TabIndex = 48;
            this.checkDT.Text = "lable";
            // 
            // checkDiaChi
            // 
            this.checkDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkDiaChi.AutoSize = true;
            this.checkDiaChi.Location = new System.Drawing.Point(1048, 91);
            this.checkDiaChi.Name = "checkDiaChi";
            this.checkDiaChi.Size = new System.Drawing.Size(38, 17);
            this.checkDiaChi.TabIndex = 48;
            this.checkDiaChi.Text = "lable";
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbNam.Location = new System.Drawing.Point(130, 141);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(70, 24);
            this.rbNam.TabIndex = 49;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbNu.Location = new System.Drawing.Point(205, 141);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(54, 24);
            this.rbNu.TabIndex = 49;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(130, 196);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(179, 27);
            this.dtpNgaySinh.TabIndex = 50;
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            // 
            // checkCongViec
            // 
            this.checkCongViec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkCongViec.AutoSize = true;
            this.checkCongViec.Location = new System.Drawing.Point(972, 196);
            this.checkCongViec.Name = "checkCongViec";
            this.checkCongViec.Size = new System.Drawing.Size(38, 17);
            this.checkCongViec.TabIndex = 51;
            this.checkCongViec.Text = "lable";
            // 
            // checkCaLam
            // 
            this.checkCaLam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkCaLam.AutoSize = true;
            this.checkCaLam.Location = new System.Drawing.Point(878, 144);
            this.checkCaLam.Name = "checkCaLam";
            this.checkCaLam.Size = new System.Drawing.Size(38, 17);
            this.checkCaLam.TabIndex = 52;
            this.checkCaLam.Text = "lable";
            // 
            // FormNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1451, 802);
            this.Controls.Add(this.checkCongViec);
            this.Controls.Add(this.checkCaLam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.checkDiaChi);
            this.Controls.Add(this.checkDT);
            this.Controls.Add(this.checkTenNV);
            this.Controls.Add(this.checkMaNV);
            this.Controls.Add(this.cbCongViec);
            this.Controls.Add(this.cbCa);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.dataGridViewNV);
            this.Name = "FormNV";
            this.Text = "FormNV";
            this.Load += new System.EventHandler(this.FormNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.ComboBox cbCa;
        private System.Windows.Forms.ComboBox cbCongViec;
        private System.Windows.Forms.Label checkMaNV;
        private System.Windows.Forms.Label checkTenNV;
        private System.Windows.Forms.Label checkDT;
        private System.Windows.Forms.Label checkDiaChi;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongViec;
        private System.Windows.Forms.Label checkCongViec;
        private System.Windows.Forms.Label checkCaLam;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
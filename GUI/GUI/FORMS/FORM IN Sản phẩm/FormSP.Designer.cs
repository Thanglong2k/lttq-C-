namespace GUI.FORMS.FORM_IN_BG
{
    partial class FormSP
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
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            this.MaBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaBinh = new System.Windows.Forms.TextBox();
            this.txtTenBinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBaoHanh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtBan = new System.Windows.Forms.TextBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.cbMau = new System.Windows.Forms.ComboBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.checkMaBinh = new System.Windows.Forms.Label();
            this.checkTenBinh = new System.Windows.Forms.Label();
            this.checkKhoiLuong = new System.Windows.Forms.Label();
            this.checkBaoHanh = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbNSX = new System.Windows.Forms.ComboBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.picboxSP = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.cbKhoiLuong = new System.Windows.Forms.ComboBox();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.checkGhiChu = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkLoai = new System.Windows.Forms.Label();
            this.checkMau = new System.Windows.Forms.Label();
            this.checkNSX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.AllowUserToAddRows = false;
            this.dataGridViewSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBinh,
            this.TenBinh,
            this.Loai,
            this.Mau,
            this.KhoiLuong,
            this.NSX,
            this.SoLuong,
            this.DonGiaNhap,
            this.DonGiaBan,
            this.BH,
            this.Anh,
            this.GhiChu});
            this.dataGridViewSP.Location = new System.Drawing.Point(26, 265);
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.ReadOnly = true;
            this.dataGridViewSP.RowHeadersWidth = 51;
            this.dataGridViewSP.RowTemplate.Height = 24;
            this.dataGridViewSP.Size = new System.Drawing.Size(1398, 512);
            this.dataGridViewSP.TabIndex = 0;
            this.dataGridViewSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSP_CellClick);
            // 
            // MaBinh
            // 
            this.MaBinh.DataPropertyName = "MaBinh";
            this.MaBinh.HeaderText = "Mã Bình";
            this.MaBinh.MinimumWidth = 6;
            this.MaBinh.Name = "MaBinh";
            this.MaBinh.ReadOnly = true;
            this.MaBinh.Width = 120;
            // 
            // TenBinh
            // 
            this.TenBinh.DataPropertyName = "TenBinh";
            this.TenBinh.HeaderText = "Tên Bình";
            this.TenBinh.MinimumWidth = 6;
            this.TenBinh.Name = "TenBinh";
            this.TenBinh.ReadOnly = true;
            this.TenBinh.Width = 200;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "MaLoai";
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 6;
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            this.Loai.Width = 125;
            // 
            // Mau
            // 
            this.Mau.DataPropertyName = "MaMau";
            this.Mau.HeaderText = "Màu";
            this.Mau.MinimumWidth = 6;
            this.Mau.Name = "Mau";
            this.Mau.ReadOnly = true;
            this.Mau.Width = 90;
            // 
            // KhoiLuong
            // 
            this.KhoiLuong.DataPropertyName = "MaKL";
            this.KhoiLuong.HeaderText = "Khối Lượng";
            this.KhoiLuong.MinimumWidth = 6;
            this.KhoiLuong.Name = "KhoiLuong";
            this.KhoiLuong.ReadOnly = true;
            this.KhoiLuong.Width = 135;
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "MaNSX";
            this.NSX.HeaderText = "Nhà Sản Xuất";
            this.NSX.MinimumWidth = 6;
            this.NSX.Name = "NSX";
            this.NSX.ReadOnly = true;
            this.NSX.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn Giá Nhập";
            this.DonGiaNhap.MinimumWidth = 6;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            this.DonGiaNhap.Width = 135;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn Giá Bán";
            this.DonGiaBan.MinimumWidth = 6;
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.ReadOnly = true;
            this.DonGiaBan.Width = 134;
            // 
            // BH
            // 
            this.BH.DataPropertyName = "ThoiGianBaoHanh";
            this.BH.HeaderText = "Thời Gian Bảo Hành";
            this.BH.MinimumWidth = 6;
            this.BH.Name = "BH";
            this.BH.ReadOnly = true;
            this.BH.Width = 135;
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.MinimumWidth = 6;
            this.Anh.Name = "Anh";
            this.Anh.ReadOnly = true;
            this.Anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Anh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Anh.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnThemSP.FlatAppearance.BorderSize = 0;
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(1313, 36);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(126, 36);
            this.btnThemSP.TabIndex = 12;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnSuaSP.FlatAppearance.BorderSize = 0;
            this.btnSuaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSP.ForeColor = System.Drawing.Color.White;
            this.btnSuaSP.Location = new System.Drawing.Point(1313, 78);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(126, 36);
            this.btnSuaSP.TabIndex = 13;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.UseVisualStyleBackColor = false;
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnXoaSP.FlatAppearance.BorderSize = 0;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(1313, 120);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(126, 36);
            this.btnXoaSP.TabIndex = 14;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Bình:";
            // 
            // txtMaBinh
            // 
            this.txtMaBinh.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaBinh.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBinh.Location = new System.Drawing.Point(102, 30);
            this.txtMaBinh.Name = "txtMaBinh";
            this.txtMaBinh.Size = new System.Drawing.Size(151, 29);
            this.txtMaBinh.TabIndex = 0;
            // 
            // txtTenBinh
            // 
            this.txtTenBinh.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBinh.Location = new System.Drawing.Point(102, 87);
            this.txtTenBinh.Name = "txtTenBinh";
            this.txtTenBinh.Size = new System.Drawing.Size(151, 29);
            this.txtTenBinh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Bình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Màu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Khối Lượng:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đơn giá:\r\nBán\r\n";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đơn Giá:\r\nNhập";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số Lượng:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(757, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ghi Chú:";
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBaoHanh.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaoHanh.Location = new System.Drawing.Point(847, 30);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(151, 29);
            this.txtBaoHanh.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(757, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 36);
            this.label10.TabIndex = 19;
            this.label10.Text = "Thời Gian:\r\nBảo Hành";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuong.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(459, 92);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(151, 29);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtNhap
            // 
            this.txtNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhap.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(459, 148);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(110, 29);
            this.txtNhap.TabIndex = 6;
            // 
            // txtBan
            // 
            this.txtBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBan.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBan.Location = new System.Drawing.Point(459, 202);
            this.txtBan.Name = "txtBan";
            this.txtBan.Size = new System.Drawing.Size(110, 29);
            this.txtBan.TabIndex = 7;
            // 
            // cbLoai
            // 
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(102, 144);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(151, 30);
            this.cbLoai.TabIndex = 2;
            // 
            // cbMau
            // 
            this.cbMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMau.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMau.FormattingEnabled = true;
            this.cbMau.Location = new System.Drawing.Point(102, 198);
            this.cbMau.Name = "cbMau";
            this.cbMau.Size = new System.Drawing.Size(96, 30);
            this.cbMau.TabIndex = 3;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGhichu.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.Location = new System.Drawing.Point(847, 146);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(151, 101);
            this.txtGhichu.TabIndex = 10;
            // 
            // checkMaBinh
            // 
            this.checkMaBinh.AutoSize = true;
            this.checkMaBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMaBinh.Location = new System.Drawing.Point(259, 35);
            this.checkMaBinh.Name = "checkMaBinh";
            this.checkMaBinh.Size = new System.Drawing.Size(50, 24);
            this.checkMaBinh.TabIndex = 24;
            this.checkMaBinh.Text = "lable";
            // 
            // checkTenBinh
            // 
            this.checkTenBinh.AutoSize = true;
            this.checkTenBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTenBinh.Location = new System.Drawing.Point(259, 92);
            this.checkTenBinh.Name = "checkTenBinh";
            this.checkTenBinh.Size = new System.Drawing.Size(50, 24);
            this.checkTenBinh.TabIndex = 24;
            this.checkTenBinh.Text = "lable";
            // 
            // checkKhoiLuong
            // 
            this.checkKhoiLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkKhoiLuong.AutoSize = true;
            this.checkKhoiLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkKhoiLuong.Location = new System.Drawing.Point(616, 35);
            this.checkKhoiLuong.Name = "checkKhoiLuong";
            this.checkKhoiLuong.Size = new System.Drawing.Size(50, 24);
            this.checkKhoiLuong.TabIndex = 24;
            this.checkKhoiLuong.Text = "lable";
            // 
            // checkBaoHanh
            // 
            this.checkBaoHanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBaoHanh.AutoSize = true;
            this.checkBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBaoHanh.Location = new System.Drawing.Point(1004, 31);
            this.checkBaoHanh.Name = "checkBaoHanh";
            this.checkBaoHanh.Size = new System.Drawing.Size(50, 24);
            this.checkBaoHanh.TabIndex = 24;
            this.checkBaoHanh.Text = "lable";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(757, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "Nước SX:";
            // 
            // cbNSX
            // 
            this.cbNSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNSX.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNSX.FormattingEnabled = true;
            this.cbNSX.Location = new System.Drawing.Point(847, 88);
            this.cbNSX.Name = "cbNSX";
            this.cbNSX.Size = new System.Drawing.Size(151, 30);
            this.cbNSX.TabIndex = 9;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnChonAnh.FlatAppearance.BorderSize = 0;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.ForeColor = System.Drawing.Color.White;
            this.btnChonAnh.Location = new System.Drawing.Point(1141, 216);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(108, 34);
            this.btnChonAnh.TabIndex = 11;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(1313, 162);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(126, 36);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(1313, 206);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(126, 41);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // picboxSP
            // 
            this.picboxSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picboxSP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picboxSP.Location = new System.Drawing.Point(1115, 30);
            this.picboxSP.Name = "picboxSP";
            this.picboxSP.Size = new System.Drawing.Size(158, 176);
            this.picboxSP.TabIndex = 23;
            this.picboxSP.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.HandPointRight;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(1313, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(126, 27);
            this.iconButton1.TabIndex = 27;
            this.iconButton1.Text = "Chi tiết";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // cbKhoiLuong
            // 
            this.cbKhoiLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoiLuong.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoiLuong.FormattingEnabled = true;
            this.cbKhoiLuong.Location = new System.Drawing.Point(459, 29);
            this.cbKhoiLuong.Name = "cbKhoiLuong";
            this.cbKhoiLuong.Size = new System.Drawing.Size(151, 30);
            this.cbKhoiLuong.TabIndex = 4;
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            // 
            // checkGhiChu
            // 
            this.checkGhiChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkGhiChu.AutoSize = true;
            this.checkGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGhiChu.Location = new System.Drawing.Point(1004, 148);
            this.checkGhiChu.Name = "checkGhiChu";
            this.checkGhiChu.Size = new System.Drawing.Size(50, 24);
            this.checkGhiChu.TabIndex = 28;
            this.checkGhiChu.Text = "lable";
            // 
            // checkLoai
            // 
            this.checkLoai.AutoSize = true;
            this.checkLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLoai.Location = new System.Drawing.Point(259, 150);
            this.checkLoai.Name = "checkLoai";
            this.checkLoai.Size = new System.Drawing.Size(50, 24);
            this.checkLoai.TabIndex = 29;
            this.checkLoai.Text = "lable";
            // 
            // checkMau
            // 
            this.checkMau.AutoSize = true;
            this.checkMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMau.Location = new System.Drawing.Point(204, 203);
            this.checkMau.Name = "checkMau";
            this.checkMau.Size = new System.Drawing.Size(50, 24);
            this.checkMau.TabIndex = 30;
            this.checkMau.Text = "lable";
            // 
            // checkNSX
            // 
            this.checkNSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkNSX.AutoSize = true;
            this.checkNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNSX.Location = new System.Drawing.Point(1004, 93);
            this.checkNSX.Name = "checkNSX";
            this.checkNSX.Size = new System.Drawing.Size(50, 24);
            this.checkNSX.TabIndex = 31;
            this.checkNSX.Text = "lable";
            // 
            // FormSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1451, 802);
            this.Controls.Add(this.checkNSX);
            this.Controls.Add(this.checkMau);
            this.Controls.Add(this.checkLoai);
            this.Controls.Add(this.checkGhiChu);
            this.Controls.Add(this.cbKhoiLuong);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.checkBaoHanh);
            this.Controls.Add(this.checkKhoiLuong);
            this.Controls.Add(this.checkTenBinh);
            this.Controls.Add(this.checkMaBinh);
            this.Controls.Add(this.picboxSP);
            this.Controls.Add(this.cbMau);
            this.Controls.Add(this.cbNSX);
            this.Controls.Add(this.cbLoai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtBaoHanh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenBinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaBinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.dataGridViewSP);
            this.Name = "FormSP";
            this.Text = "FormSP";
            this.Load += new System.EventHandler(this.FormSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaBinh;
        private System.Windows.Forms.TextBox txtTenBinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBaoHanh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtBan;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.ComboBox cbMau;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.PictureBox picboxSP;
        private System.Windows.Forms.Label checkMaBinh;
        private System.Windows.Forms.Label checkTenBinh;
        private System.Windows.Forms.Label checkKhoiLuong;
        private System.Windows.Forms.Label checkBaoHanh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbNSX;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLuu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox cbKhoiLuong;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BH;
        private System.Windows.Forms.DataGridViewImageColumn Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Label checkGhiChu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label checkLoai;
        private System.Windows.Forms.Label checkMau;
        private System.Windows.Forms.Label checkNSX;
    }
}
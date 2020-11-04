namespace GUI.FORMS.FORM_IN_HD
{
    partial class FormTKHD
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
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimTK1 = new FontAwesome.Sharp.IconButton();
            this.cbNhaCC = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbNgayNhap = new System.Windows.Forms.CheckBox();
            this.cbMaBinh = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.buttonExit.IconColor = System.Drawing.Color.White;
            this.buttonExit.IconSize = 15;
            this.buttonExit.Location = new System.Drawing.Point(453, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(66, 51);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 51);
            this.panel1.TabIndex = 43;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 93;
            this.iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 94;
            this.label4.Text = "Tìm kiếm hóa đơn";
            // 
            // btnTimTK1
            // 
            this.btnTimTK1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimTK1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnTimTK1.FlatAppearance.BorderSize = 0;
            this.btnTimTK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTK1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTimTK1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTK1.ForeColor = System.Drawing.Color.White;
            this.btnTimTK1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimTK1.IconColor = System.Drawing.Color.White;
            this.btnTimTK1.IconSize = 20;
            this.btnTimTK1.Location = new System.Drawing.Point(126, 246);
            this.btnTimTK1.Name = "btnTimTK1";
            this.btnTimTK1.Rotation = 0D;
            this.btnTimTK1.Size = new System.Drawing.Size(262, 60);
            this.btnTimTK1.TabIndex = 45;
            this.btnTimTK1.Text = "Tìm";
            this.btnTimTK1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimTK1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimTK1.UseVisualStyleBackColor = false;
            this.btnTimTK1.Click += new System.EventHandler(this.btnTimTK1_Click);
            // 
            // cbNhaCC
            // 
            this.cbNhaCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNhaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaCC.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhaCC.FormattingEnabled = true;
            this.cbNhaCC.Location = new System.Drawing.Point(169, 133);
            this.cbNhaCC.Name = "cbNhaCC";
            this.cbNhaCC.Size = new System.Drawing.Size(233, 28);
            this.cbNhaCC.TabIndex = 91;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(169, 182);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(233, 27);
            this.dtpNgayNhap.TabIndex = 90;
            this.dtpNgayNhap.Value = new System.DateTime(2020, 10, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(65, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 89;
            this.label2.Text = "Ngày Nhập:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(88, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 88;
            this.label1.Text = "Mã Bình:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(90, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 87;
            this.label5.Text = "Nhà CC:";
            // 
            // chbNgayNhap
            // 
            this.chbNgayNhap.AutoSize = true;
            this.chbNgayNhap.Location = new System.Drawing.Point(412, 187);
            this.chbNgayNhap.Name = "chbNgayNhap";
            this.chbNgayNhap.Size = new System.Drawing.Size(18, 17);
            this.chbNgayNhap.TabIndex = 93;
            this.chbNgayNhap.UseVisualStyleBackColor = true;
            this.chbNgayNhap.CheckedChanged += new System.EventHandler(this.chbNgayNhap_CheckedChanged);
            // 
            // cbMaBinh
            // 
            this.cbMaBinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaBinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaBinh.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaBinh.FormattingEnabled = true;
            this.cbMaBinh.Location = new System.Drawing.Point(169, 86);
            this.cbMaBinh.Name = "cbMaBinh";
            this.cbMaBinh.Size = new System.Drawing.Size(233, 28);
            this.cbMaBinh.TabIndex = 94;
            // 
            // FormTKHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(519, 339);
            this.Controls.Add(this.cbMaBinh);
            this.Controls.Add(this.chbNgayNhap);
            this.Controls.Add(this.cbNhaCC);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTimTK1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTKHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTKHD";
            this.Load += new System.EventHandler(this.FormTKHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnTimTK1;
        private System.Windows.Forms.ComboBox cbNhaCC;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbNgayNhap;
        private System.Windows.Forms.ComboBox cbMaBinh;
    }
}
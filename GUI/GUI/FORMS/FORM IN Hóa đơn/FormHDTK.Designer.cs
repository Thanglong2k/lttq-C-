namespace GUI.FORMS.FORM_IN_HD
{
    partial class FormHDTK
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
            this.dataGridViewTK1 = new System.Windows.Forms.DataGridView();
            this.btnXoaTK1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimTK1 = new FontAwesome.Sharp.IconButton();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cbNhaCC = new System.Windows.Forms.ComboBox();
            this.txtMaBinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTK1
            // 
            this.dataGridViewTK1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTK1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTK1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTK1.Location = new System.Drawing.Point(27, 261);
            this.dataGridViewTK1.Name = "dataGridViewTK1";
            this.dataGridViewTK1.ReadOnly = true;
            this.dataGridViewTK1.RowHeadersWidth = 51;
            this.dataGridViewTK1.RowTemplate.Height = 24;
            this.dataGridViewTK1.Size = new System.Drawing.Size(1195, 416);
            this.dataGridViewTK1.TabIndex = 39;
            // 
            // btnXoaTK1
            // 
            this.btnXoaTK1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaTK1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnXoaTK1.FlatAppearance.BorderSize = 0;
            this.btnXoaTK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTK1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK1.ForeColor = System.Drawing.Color.White;
            this.btnXoaTK1.Location = new System.Drawing.Point(724, 134);
            this.btnXoaTK1.Name = "btnXoaTK1";
            this.btnXoaTK1.Size = new System.Drawing.Size(262, 60);
            this.btnXoaTK1.TabIndex = 37;
            this.btnXoaTK1.Text = "Xóa";
            this.btnXoaTK1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(257, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ngày Nhập:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(280, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã Bình:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(282, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Nhà CC:";
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
            this.btnTimTK1.Location = new System.Drawing.Point(724, 68);
            this.btnTimTK1.Name = "btnTimTK1";
            this.btnTimTK1.Rotation = 0D;
            this.btnTimTK1.Size = new System.Drawing.Size(262, 60);
            this.btnTimTK1.TabIndex = 38;
            this.btnTimTK1.Text = "Tìm";
            this.btnTimTK1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimTK1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimTK1.UseVisualStyleBackColor = false;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(361, 168);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(233, 27);
            this.dtpNgayNhap.TabIndex = 69;
            // 
            // cbNhaCC
            // 
            this.cbNhaCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNhaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaCC.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhaCC.FormattingEnabled = true;
            this.cbNhaCC.Location = new System.Drawing.Point(361, 119);
            this.cbNhaCC.Name = "cbNhaCC";
            this.cbNhaCC.Size = new System.Drawing.Size(233, 28);
            this.cbNhaCC.TabIndex = 85;
            // 
            // txtMaBinh
            // 
            this.txtMaBinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaBinh.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBinh.Location = new System.Drawing.Point(361, 71);
            this.txtMaBinh.Name = "txtMaBinh";
            this.txtMaBinh.Size = new System.Drawing.Size(233, 29);
            this.txtMaBinh.TabIndex = 86;
            // 
            // FormHDTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 702);
            this.Controls.Add(this.txtMaBinh);
            this.Controls.Add(this.cbNhaCC);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.dataGridViewTK1);
            this.Controls.Add(this.btnTimTK1);
            this.Controls.Add(this.btnXoaTK1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "FormHDTK";
            this.Text = "FormHDTK";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTK1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewTK1;
        private FontAwesome.Sharp.IconButton btnTimTK1;
        private System.Windows.Forms.Button btnXoaTK1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.ComboBox cbNhaCC;
        private System.Windows.Forms.TextBox txtMaBinh;
    }
}
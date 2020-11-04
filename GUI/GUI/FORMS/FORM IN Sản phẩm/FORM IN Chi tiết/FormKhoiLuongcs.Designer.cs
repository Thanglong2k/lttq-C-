namespace GUI.FORMS.FORM_IN_Sản_phẩm.FORM_IN_Chi_tiết
{
    partial class FormKhoiLuongcs
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
            this.dataGridViewKL = new System.Windows.Forms.DataGridView();
            this.makhoiluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkKL = new System.Windows.Forms.Label();
            this.txtMaKhoiLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKL)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKL
            // 
            this.dataGridViewKL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhoiluong});
            this.dataGridViewKL.Location = new System.Drawing.Point(12, 156);
            this.dataGridViewKL.Name = "dataGridViewKL";
            this.dataGridViewKL.RowHeadersWidth = 51;
            this.dataGridViewKL.RowTemplate.Height = 24;
            this.dataGridViewKL.Size = new System.Drawing.Size(696, 183);
            this.dataGridViewKL.TabIndex = 101;
            this.dataGridViewKL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKL_CellClick);
            // 
            // makhoiluong
            // 
            this.makhoiluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makhoiluong.DataPropertyName = "MaKL";
            this.makhoiluong.HeaderText = "Mã khối lượng";
            this.makhoiluong.MinimumWidth = 6;
            this.makhoiluong.Name = "makhoiluong";
            this.makhoiluong.ReadOnly = true;
            // 
            // checkKL
            // 
            this.checkKL.AutoSize = true;
            this.checkKL.Location = new System.Drawing.Point(387, 52);
            this.checkKL.Name = "checkKL";
            this.checkKL.Size = new System.Drawing.Size(38, 17);
            this.checkKL.TabIndex = 99;
            this.checkKL.Text = "lable";
            // 
            // txtMaKhoiLuong
            // 
            this.txtMaKhoiLuong.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoiLuong.Location = new System.Drawing.Point(124, 47);
            this.txtMaKhoiLuong.Name = "txtMaKhoiLuong";
            this.txtMaKhoiLuong.Size = new System.Drawing.Size(257, 29);
            this.txtMaKhoiLuong.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 18);
            this.label9.TabIndex = 95;
            this.label9.Text = "Mã khối lượng:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(568, 94);
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
            this.btnThem.Location = new System.Drawing.Point(568, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 34);
            this.btnThem.TabIndex = 93;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormKhoiLuongcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(719, 373);
            this.Controls.Add(this.dataGridViewKL);
            this.Controls.Add(this.checkKL);
            this.Controls.Add(this.txtMaKhoiLuong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKhoiLuongcs";
            this.Text = "FormKhoiLuongcs";
            this.Load += new System.EventHandler(this.FormKhoiLuongcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKL;
        private System.Windows.Forms.Label checkKL;
        private System.Windows.Forms.TextBox txtMaKhoiLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoiluong;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
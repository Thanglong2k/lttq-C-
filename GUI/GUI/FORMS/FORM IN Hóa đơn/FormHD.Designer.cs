namespace GUI
{
    partial class FormHD
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
            this.btnHDB = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHDN = new System.Windows.Forms.Button();
            this.panelHD = new System.Windows.Forms.Panel();
            this.paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHDB
            // 
            this.btnHDB.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHDB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnHDB.FlatAppearance.BorderSize = 0;
            this.btnHDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHDB.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnHDB.Location = new System.Drawing.Point(0, 0);
            this.btnHDB.Name = "btnHDB";
            this.btnHDB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHDB.Size = new System.Drawing.Size(231, 42);
            this.btnHDB.TabIndex = 1;
            this.btnHDB.Text = "Hóa đơn bán";
            this.btnHDB.UseVisualStyleBackColor = true;
            this.btnHDB.Click += new System.EventHandler(this.btnHDB_Click);
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.btnTimKiem);
            this.paneltop.Controls.Add(this.btnHDN);
            this.paneltop.Controls.Add(this.btnHDB);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1251, 42);
            this.paneltop.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnTimKiem.Location = new System.Drawing.Point(462, 0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(231, 42);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHDN
            // 
            this.btnHDN.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHDN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnHDN.FlatAppearance.BorderSize = 0;
            this.btnHDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHDN.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnHDN.Location = new System.Drawing.Point(231, 0);
            this.btnHDN.Name = "btnHDN";
            this.btnHDN.Size = new System.Drawing.Size(231, 42);
            this.btnHDN.TabIndex = 2;
            this.btnHDN.Text = "Hóa đơn nhập";
            this.btnHDN.UseVisualStyleBackColor = true;
            this.btnHDN.Click += new System.EventHandler(this.btnHDN_Click);
            // 
            // panelHD
            // 
            this.panelHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHD.Location = new System.Drawing.Point(0, 42);
            this.panelHD.Name = "panelHD";
            this.panelHD.Size = new System.Drawing.Size(1251, 660);
            this.panelHD.TabIndex = 4;
            // 
            // FormHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1251, 702);
            this.Controls.Add(this.panelHD);
            this.Controls.Add(this.paneltop);
            this.Name = "FormHD";
            this.Text = "FormHD";
            this.Load += new System.EventHandler(this.FormHD_Load);
            this.paneltop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHDB;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button btnHDN;
        private System.Windows.Forms.Panel panelHD;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
namespace GUI.FORMS.FORM_IN_BC
{
    partial class FormBC1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNV = new System.Windows.Forms.ComboBox();
            this.btnHIenThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(4, 84);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1083, 619);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn nhân viên :";
            // 
            // cbNV
            // 
            this.cbNV.FormattingEnabled = true;
            this.cbNV.Location = new System.Drawing.Point(146, 31);
            this.cbNV.Name = "cbNV";
            this.cbNV.Size = new System.Drawing.Size(292, 24);
            this.cbNV.TabIndex = 2;
            // 
            // btnHIenThi
            // 
            this.btnHIenThi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHIenThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnHIenThi.FlatAppearance.BorderSize = 0;
            this.btnHIenThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHIenThi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHIenThi.ForeColor = System.Drawing.Color.White;
            this.btnHIenThi.Location = new System.Drawing.Point(471, 21);
            this.btnHIenThi.Name = "btnHIenThi";
            this.btnHIenThi.Size = new System.Drawing.Size(115, 41);
            this.btnHIenThi.TabIndex = 71;
            this.btnHIenThi.Text = "Hiển thị";
            this.btnHIenThi.UseVisualStyleBackColor = false;
            this.btnHIenThi.Click += new System.EventHandler(this.btnHIenThi_Click);
            // 
            // FormBC1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1099, 658);
            this.Controls.Add(this.btnHIenThi);
            this.Controls.Add(this.cbNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBC1";
            this.Text = "FormBC1";
            this.Load += new System.EventHandler(this.FormBC1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNV;
        private System.Windows.Forms.Button btnHIenThi;
    }
}
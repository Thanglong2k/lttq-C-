namespace GUI.FORMS
{
    partial class FormBC
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
            this.cbBCSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbBCSelection
            // 
            this.cbBCSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBCSelection.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBCSelection.FormattingEnabled = true;
            this.cbBCSelection.Items.AddRange(new object[] {
            "Báo cáo danh sách 3 sản phẩm được bán ít nhất từ một NV chọn trước",
            "Báo cáo danh sách hoá đơn và tổng tiền nhập hàng từ một NCC trong một tháng chọn " +
                "trước",
            "Báo cáo doanh thu của cửa hàng theo tháng chọn trước",
            "Báo cáo ds các khách hàng có mua hàng theo tháng chọn trước"});
            this.cbBCSelection.Location = new System.Drawing.Point(27, 23);
            this.cbBCSelection.Name = "cbBCSelection";
            this.cbBCSelection.Size = new System.Drawing.Size(676, 28);
            this.cbBCSelection.TabIndex = 50;
            this.cbBCSelection.SelectedIndexChanged += new System.EventHandler(this.cbBCSelection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(709, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "-Chọn loại báo cáo";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Location = new System.Drawing.Point(12, 79);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1427, 711);
            this.panelMain.TabIndex = 53;
            // 
            // FormBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1451, 802);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBCSelection);
            this.Name = "FormBC";
            this.Text = "FormBC";
            this.Load += new System.EventHandler(this.FormBC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbBCSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
    }
}
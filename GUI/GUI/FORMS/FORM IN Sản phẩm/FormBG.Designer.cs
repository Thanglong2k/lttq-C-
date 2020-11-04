namespace GUI
{
    partial class FormBG
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
            this.buttonSP = new System.Windows.Forms.Button();
            this.paneltop = new System.Windows.Forms.Panel();
            this.buttonTK1 = new System.Windows.Forms.Button();
            this.panelSP = new System.Windows.Forms.Panel();
            this.paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSP
            // 
            this.buttonSP.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.buttonSP.FlatAppearance.BorderSize = 0;
            this.buttonSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSP.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.buttonSP.Location = new System.Drawing.Point(0, 0);
            this.buttonSP.Name = "buttonSP";
            this.buttonSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSP.Size = new System.Drawing.Size(231, 42);
            this.buttonSP.TabIndex = 1;
            this.buttonSP.Text = "Sản phẩm";
            this.buttonSP.UseVisualStyleBackColor = true;
            this.buttonSP.Click += new System.EventHandler(this.buttonSP_Click);
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.buttonTK1);
            this.paneltop.Controls.Add(this.buttonSP);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(937, 42);
            this.paneltop.TabIndex = 2;
            // 
            // buttonTK1
            // 
            this.buttonTK1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTK1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.buttonTK1.FlatAppearance.BorderSize = 0;
            this.buttonTK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTK1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTK1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.buttonTK1.Location = new System.Drawing.Point(231, 0);
            this.buttonTK1.Name = "buttonTK1";
            this.buttonTK1.Size = new System.Drawing.Size(231, 42);
            this.buttonTK1.TabIndex = 2;
            this.buttonTK1.Text = "Tìm kiếm";
            this.buttonTK1.UseVisualStyleBackColor = true;
            this.buttonTK1.Click += new System.EventHandler(this.buttonTK1_Click);
            // 
            // panelSP
            // 
            this.panelSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSP.Location = new System.Drawing.Point(0, 42);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(937, 539);
            this.panelSP.TabIndex = 3;
            // 
            // FormBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 581);
            this.Controls.Add(this.panelSP);
            this.Controls.Add(this.paneltop);
            this.Name = "FormBG";
            this.Text = "FormBG";
            this.Load += new System.EventHandler(this.FormBG_Load);
            this.paneltop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSP;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button buttonTK1;
        private System.Windows.Forms.Panel panelSP;
    }
}
namespace GUI.FORMS.FORM_IN_BG
{
    partial class FormTKBG
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
            this.cbLoaiTK1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.btnTimTK1 = new FontAwesome.Sharp.IconButton();
            this.cbKLTK1 = new System.Windows.Forms.ComboBox();
            this.txtBHTK1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiTK1
            // 
            this.cbLoaiTK1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLoaiTK1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiTK1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiTK1.FormattingEnabled = true;
            this.cbLoaiTK1.Location = new System.Drawing.Point(189, 84);
            this.cbLoaiTK1.Name = "cbLoaiTK1";
            this.cbLoaiTK1.Size = new System.Drawing.Size(233, 33);
            this.cbLoaiTK1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(22, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Thời Gian Bảo Hành:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(138, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Loại:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(85, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Khối Lượng:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 51);
            this.panel1.TabIndex = 42;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 43;
            this.iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tìm kiếm sản phẩm";
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
            this.btnTimTK1.Location = new System.Drawing.Point(189, 262);
            this.btnTimTK1.Name = "btnTimTK1";
            this.btnTimTK1.Rotation = 0D;
            this.btnTimTK1.Size = new System.Drawing.Size(135, 44);
            this.btnTimTK1.TabIndex = 0;
            this.btnTimTK1.Text = "Tìm";
            this.btnTimTK1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimTK1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimTK1.UseVisualStyleBackColor = false;
            this.btnTimTK1.Click += new System.EventHandler(this.btnTimTK1_Click);
            // 
            // cbKLTK1
            // 
            this.cbKLTK1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbKLTK1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKLTK1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKLTK1.FormattingEnabled = true;
            this.cbKLTK1.Location = new System.Drawing.Point(189, 131);
            this.cbKLTK1.Name = "cbKLTK1";
            this.cbKLTK1.Size = new System.Drawing.Size(233, 33);
            this.cbKLTK1.TabIndex = 43;
            // 
            // txtBHTK1
            // 
            this.txtBHTK1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBHTK1.Location = new System.Drawing.Point(189, 181);
            this.txtBHTK1.Name = "txtBHTK1";
            this.txtBHTK1.Size = new System.Drawing.Size(233, 32);
            this.txtBHTK1.TabIndex = 44;
            this.txtBHTK1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBHTK1_KeyPress);
            // 
            // FormTKBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(519, 340);
            this.Controls.Add(this.txtBHTK1);
            this.Controls.Add(this.cbKLTK1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbLoaiTK1);
            this.Controls.Add(this.btnTimTK1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTKBG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTKBG";
            this.Load += new System.EventHandler(this.FormTKBG_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbLoaiTK1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnTimTK1;
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox cbKLTK1;
        private System.Windows.Forms.TextBox txtBHTK1;
    }
}
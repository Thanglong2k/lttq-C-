namespace GUI.FORMS
{
    partial class FormChangePass
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.txtNewPassCheck = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.lbTB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 51);
            this.panel1.TabIndex = 4;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 94;
            this.iconPictureBox1.TabStop = false;
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
            this.buttonExit.Location = new System.Drawing.Point(375, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(66, 51);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Đổi mật khẩu";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(32, 445);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(367, 59);
            this.btnChangePass.TabIndex = 19;
            this.btnChangePass.Text = "ĐỔI MẬT KHẨU";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.iconPictureBox5);
            this.panel6.Controls.Add(this.txtNewPassCheck);
            this.panel6.Location = new System.Drawing.Point(32, 322);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(367, 62);
            this.panel6.TabIndex = 18;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            this.panel6.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Link;
            this.iconPictureBox5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox5.IconSize = 25;
            this.iconPictureBox5.Location = new System.Drawing.Point(12, 20);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox5.TabIndex = 6;
            this.iconPictureBox5.TabStop = false;
            // 
            // txtNewPassCheck
            // 
            this.txtNewPassCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassCheck.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewPassCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassCheck.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassCheck.Location = new System.Drawing.Point(57, 21);
            this.txtNewPassCheck.Name = "txtNewPassCheck";
            this.txtNewPassCheck.Size = new System.Drawing.Size(272, 29);
            this.txtNewPassCheck.TabIndex = 1;
            this.txtNewPassCheck.Click += new System.EventHandler(this.txtNewPassCheck_Click);
            this.txtNewPassCheck.MouseLeave += new System.EventHandler(this.txtNewPassCheck_MouseLeave);
            this.txtNewPassCheck.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtNewPassCheck_MouseMove);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.iconPictureBox4);
            this.panel5.Controls.Add(this.txtNewPass);
            this.panel5.Location = new System.Drawing.Point(32, 241);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(367, 62);
            this.panel5.TabIndex = 17;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            this.panel5.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox4.IconSize = 25;
            this.iconPictureBox4.Location = new System.Drawing.Point(12, 20);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox4.TabIndex = 6;
            this.iconPictureBox4.TabStop = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(57, 21);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(272, 29);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.Click += new System.EventHandler(this.txtNewPass_Click);
            this.txtNewPass.MouseLeave += new System.EventHandler(this.txtNewPass_MouseLeave);
            this.txtNewPass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtNewPass_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.iconPictureBox3);
            this.panel4.Controls.Add(this.txtOldPass);
            this.panel4.Location = new System.Drawing.Point(31, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 62);
            this.panel4.TabIndex = 15;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox3.IconSize = 25;
            this.iconPictureBox3.Location = new System.Drawing.Point(12, 20);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 6;
            this.iconPictureBox3.TabStop = false;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOldPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPass.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOldPass.ForeColor = System.Drawing.Color.Black;
            this.txtOldPass.Location = new System.Drawing.Point(58, 22);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(272, 29);
            this.txtOldPass.TabIndex = 1;
            this.txtOldPass.Click += new System.EventHandler(this.txtOldPass_Click);
            this.txtOldPass.MouseLeave += new System.EventHandler(this.txtOldPass_MouseLeave);
            this.txtOldPass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtOldPass_MouseMove);
            // 
            // lbTB
            // 
            this.lbTB.AutoSize = true;
            this.lbTB.Location = new System.Drawing.Point(28, 101);
            this.lbTB.Name = "lbTB";
            this.lbTB.Size = new System.Drawing.Size(46, 17);
            this.lbTB.TabIndex = 20;
            this.lbTB.Text = "label1";
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(441, 541);
            this.Controls.Add(this.lbTB);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChangePass";
            this.Load += new System.EventHandler(this.FormChangePass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.TextBox txtNewPassCheck;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.TextBox txtOldPass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lbTB;
    }
}
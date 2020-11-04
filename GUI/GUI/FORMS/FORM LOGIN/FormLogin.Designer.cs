namespace GUI.FORMS
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMIN = new FontAwesome.Sharp.IconButton();
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelTB = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelSignup = new System.Windows.Forms.Panel();
            this.btnSignupDK = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.txtPassCheckDK = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.txtPassDK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.txtUsernameDK = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelSignup.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.buttonMIN);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 51);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonMIN
            // 
            this.buttonMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMIN.FlatAppearance.BorderSize = 0;
            this.buttonMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMIN.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMIN.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.buttonMIN.IconColor = System.Drawing.Color.White;
            this.buttonMIN.IconSize = 15;
            this.buttonMIN.Location = new System.Drawing.Point(319, 0);
            this.buttonMIN.Name = "buttonMIN";
            this.buttonMIN.Rotation = 0D;
            this.buttonMIN.Size = new System.Drawing.Size(66, 51);
            this.buttonMIN.TabIndex = 0;
            this.buttonMIN.UseVisualStyleBackColor = true;
            this.buttonMIN.Click += new System.EventHandler(this.buttonMIN_Click);
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
            this.buttonExit.Location = new System.Drawing.Point(391, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(66, 51);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLogin.Controls.Add(this.labelTB);
            this.panelLogin.Controls.Add(this.linkLabel1);
            this.panelLogin.Controls.Add(this.panelSignup);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.panel3);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Location = new System.Drawing.Point(0, 51);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(457, 499);
            this.panelLogin.TabIndex = 0;
            // 
            // labelTB
            // 
            this.labelTB.AutoSize = true;
            this.labelTB.Location = new System.Drawing.Point(44, 140);
            this.labelTB.Name = "labelTB";
            this.labelTB.Size = new System.Drawing.Size(46, 17);
            this.labelTB.TabIndex = 1;
            this.labelTB.Text = "label3";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(293, 449);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panelSignup
            // 
            this.panelSignup.Controls.Add(this.btnSignupDK);
            this.panelSignup.Controls.Add(this.panel6);
            this.panelSignup.Controls.Add(this.panel5);
            this.panelSignup.Controls.Add(this.label2);
            this.panelSignup.Controls.Add(this.panel4);
            this.panelSignup.Controls.Add(this.btnReturn);
            this.panelSignup.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSignup.Location = new System.Drawing.Point(456, 0);
            this.panelSignup.Name = "panelSignup";
            this.panelSignup.Size = new System.Drawing.Size(1, 499);
            this.panelSignup.TabIndex = 10;
            // 
            // btnSignupDK
            // 
            this.btnSignupDK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignupDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnSignupDK.FlatAppearance.BorderSize = 0;
            this.btnSignupDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignupDK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignupDK.ForeColor = System.Drawing.Color.White;
            this.btnSignupDK.Location = new System.Drawing.Point(-184, 402);
            this.btnSignupDK.Name = "btnSignupDK";
            this.btnSignupDK.Size = new System.Drawing.Size(367, 59);
            this.btnSignupDK.TabIndex = 14;
            this.btnSignupDK.Text = "ĐĂNG KÝ";
            this.btnSignupDK.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.iconPictureBox5);
            this.panel6.Controls.Add(this.txtPassCheckDK);
            this.panel6.Location = new System.Drawing.Point(-183, 299);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(367, 62);
            this.panel6.TabIndex = 3;
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
            // txtPassCheckDK
            // 
            this.txtPassCheckDK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassCheckDK.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassCheckDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassCheckDK.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCheckDK.Location = new System.Drawing.Point(57, 21);
            this.txtPassCheckDK.Name = "txtPassCheckDK";
            this.txtPassCheckDK.Size = new System.Drawing.Size(272, 29);
            this.txtPassCheckDK.TabIndex = 0;
            this.txtPassCheckDK.Click += new System.EventHandler(this.txtPassCheckDK_Click);
            this.txtPassCheckDK.MouseLeave += new System.EventHandler(this.txtPassCheckDK_MouseLeave);
            this.txtPassCheckDK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtPassCheckDK_MouseMove);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.iconPictureBox4);
            this.panel5.Controls.Add(this.txtPassDK);
            this.panel5.Location = new System.Drawing.Point(-183, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(367, 62);
            this.panel5.TabIndex = 2;
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
            // txtPassDK
            // 
            this.txtPassDK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassDK.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassDK.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassDK.Location = new System.Drawing.Point(57, 21);
            this.txtPassDK.Name = "txtPassDK";
            this.txtPassDK.Size = new System.Drawing.Size(272, 29);
            this.txtPassDK.TabIndex = 0;
            this.txtPassDK.Click += new System.EventHandler(this.txtPassDK_Click);
            this.txtPassDK.MouseLeave += new System.EventHandler(this.txtPassDK_MouseLeave);
            this.txtPassDK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtPassDK_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "ĐĂNG KÝ";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.iconPictureBox3);
            this.panel4.Controls.Add(this.txtUsernameDK);
            this.panel4.Location = new System.Drawing.Point(-184, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 62);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox3.IconSize = 25;
            this.iconPictureBox3.Location = new System.Drawing.Point(12, 20);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 6;
            this.iconPictureBox3.TabStop = false;
            // 
            // txtUsernameDK
            // 
            this.txtUsernameDK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsernameDK.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsernameDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameDK.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsernameDK.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameDK.Location = new System.Drawing.Point(58, 22);
            this.txtUsernameDK.Name = "txtUsernameDK";
            this.txtUsernameDK.Size = new System.Drawing.Size(272, 29);
            this.txtUsernameDK.TabIndex = 0;
            this.txtUsernameDK.Click += new System.EventHandler(this.txtUsernameDK_Click);
            this.txtUsernameDK.MouseLeave += new System.EventHandler(this.txtUsernameDK_MouseLeave);
            this.txtUsernameDK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtUsernameDK_MouseMove);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.AutoSize = true;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.DarkGray;
            this.btnReturn.Location = new System.Drawing.Point(-197, 48);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(80, 20);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "< Quay lại";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnReturn.MouseLeave += new System.EventHandler(this.btnReturn_MouseLeave);
            this.btnReturn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReturn_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME!";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(44, 355);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(367, 82);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.iconPictureBox2);
            this.panel3.Controls.Add(this.txtPass);
            this.panel3.Location = new System.Drawing.Point(44, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 62);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 20);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 6;
            this.iconPictureBox2.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(57, 21);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(272, 29);
            this.txtPass.TabIndex = 0;
            this.txtPass.Click += new System.EventHandler(this.txtPass_Click);
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtPass.MouseLeave += new System.EventHandler(this.txtPass_MouseLeave);
            this.txtPass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtPass_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Location = new System.Drawing.Point(44, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 62);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 20);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(58, 22);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(272, 29);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            this.txtUserName.MouseLeave += new System.EventHandler(this.txtUserName_MouseLeave);
            this.txtUserName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtUserName_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo_3;
            this.pictureBox1.Location = new System.Drawing.Point(296, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(457, 551);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelSignup.ResumeLayout(false);
            this.panelSignup.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonMIN;
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSignup;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.TextBox txtUsernameDK;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.TextBox txtPassCheckDK;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.TextBox txtPassDK;
        private System.Windows.Forms.Button btnSignupDK;
        private System.Windows.Forms.Label labelTB;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
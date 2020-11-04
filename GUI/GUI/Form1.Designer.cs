namespace BTL_Form
{
    partial class Form1
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
            this.leftpanel = new System.Windows.Forms.Panel();
            this.buttonBC = new FontAwesome.Sharp.IconButton();
            this.buttonKH = new FontAwesome.Sharp.IconButton();
            this.buttonHD = new FontAwesome.Sharp.IconButton();
            this.buttonNV = new FontAwesome.Sharp.IconButton();
            this.buttonBG = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonLG = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMAX = new FontAwesome.Sharp.IconButton();
            this.buttonMIN = new FontAwesome.Sharp.IconButton();
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.panelmain = new System.Windows.Forms.Panel();
            this.labletime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.leftpanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLG)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(83)))));
            this.leftpanel.Controls.Add(this.buttonBC);
            this.leftpanel.Controls.Add(this.buttonKH);
            this.leftpanel.Controls.Add(this.buttonHD);
            this.leftpanel.Controls.Add(this.buttonNV);
            this.leftpanel.Controls.Add(this.buttonBG);
            this.leftpanel.Controls.Add(this.panelLogo);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(231, 800);
            this.leftpanel.TabIndex = 1;
            // 
            // buttonBC
            // 
            this.buttonBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBC.FlatAppearance.BorderSize = 0;
            this.buttonBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonBC.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBC.ForeColor = System.Drawing.Color.White;
            this.buttonBC.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.buttonBC.IconColor = System.Drawing.Color.White;
            this.buttonBC.IconSize = 25;
            this.buttonBC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBC.Location = new System.Drawing.Point(0, 411);
            this.buttonBC.Name = "buttonBC";
            this.buttonBC.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonBC.Rotation = 0D;
            this.buttonBC.Size = new System.Drawing.Size(231, 75);
            this.buttonBC.TabIndex = 5;
            this.buttonBC.Text = " BÁO CÁO";
            this.buttonBC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBC.UseVisualStyleBackColor = true;
            this.buttonBC.Click += new System.EventHandler(this.buttonBC_Click);
            // 
            // buttonKH
            // 
            this.buttonKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKH.FlatAppearance.BorderSize = 0;
            this.buttonKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKH.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonKH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKH.ForeColor = System.Drawing.Color.White;
            this.buttonKH.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.buttonKH.IconColor = System.Drawing.Color.White;
            this.buttonKH.IconSize = 25;
            this.buttonKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKH.Location = new System.Drawing.Point(0, 336);
            this.buttonKH.Name = "buttonKH";
            this.buttonKH.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonKH.Rotation = 0D;
            this.buttonKH.Size = new System.Drawing.Size(231, 75);
            this.buttonKH.TabIndex = 4;
            this.buttonKH.Text = " KHÁCH HÀNG";
            this.buttonKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKH.UseVisualStyleBackColor = true;
            this.buttonKH.Click += new System.EventHandler(this.buttonKH_Click);
            // 
            // buttonHD
            // 
            this.buttonHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHD.FlatAppearance.BorderSize = 0;
            this.buttonHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHD.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonHD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHD.ForeColor = System.Drawing.Color.White;
            this.buttonHD.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.buttonHD.IconColor = System.Drawing.Color.White;
            this.buttonHD.IconSize = 25;
            this.buttonHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHD.Location = new System.Drawing.Point(0, 261);
            this.buttonHD.Name = "buttonHD";
            this.buttonHD.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonHD.Rotation = 0D;
            this.buttonHD.Size = new System.Drawing.Size(231, 75);
            this.buttonHD.TabIndex = 3;
            this.buttonHD.Text = " HÓA ĐƠN";
            this.buttonHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHD.UseVisualStyleBackColor = true;
            this.buttonHD.Click += new System.EventHandler(this.buttonHD_Click);
            // 
            // buttonNV
            // 
            this.buttonNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNV.FlatAppearance.BorderSize = 0;
            this.buttonNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonNV.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNV.ForeColor = System.Drawing.Color.White;
            this.buttonNV.IconChar = FontAwesome.Sharp.IconChar.Male;
            this.buttonNV.IconColor = System.Drawing.Color.White;
            this.buttonNV.IconSize = 25;
            this.buttonNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNV.Location = new System.Drawing.Point(0, 186);
            this.buttonNV.Name = "buttonNV";
            this.buttonNV.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonNV.Rotation = 0D;
            this.buttonNV.Size = new System.Drawing.Size(231, 75);
            this.buttonNV.TabIndex = 2;
            this.buttonNV.Text = " NHÂN VIÊN";
            this.buttonNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNV.UseVisualStyleBackColor = true;
            this.buttonNV.Click += new System.EventHandler(this.buttonNV_Click);
            // 
            // buttonBG
            // 
            this.buttonBG.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBG.FlatAppearance.BorderSize = 0;
            this.buttonBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBG.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonBG.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBG.ForeColor = System.Drawing.Color.White;
            this.buttonBG.IconChar = FontAwesome.Sharp.IconChar.Burn;
            this.buttonBG.IconColor = System.Drawing.Color.White;
            this.buttonBG.IconSize = 25;
            this.buttonBG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBG.Location = new System.Drawing.Point(0, 111);
            this.buttonBG.Name = "buttonBG";
            this.buttonBG.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonBG.Rotation = 0D;
            this.buttonBG.Size = new System.Drawing.Size(231, 75);
            this.buttonBG.TabIndex = 1;
            this.buttonBG.Text = " SẢN PHẨM";
            this.buttonBG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBG.UseVisualStyleBackColor = true;
            this.buttonBG.Click += new System.EventHandler(this.buttonBG_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.buttonLG);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(231, 111);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonLG
            // 
            this.buttonLG.Image = global::BTL_Form.Properties.Resources.petrolimex;
            this.buttonLG.Location = new System.Drawing.Point(40, 0);
            this.buttonLG.Name = "buttonLG";
            this.buttonLG.Size = new System.Drawing.Size(153, 111);
            this.buttonLG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonLG.TabIndex = 0;
            this.buttonLG.TabStop = false;
            this.buttonLG.Click += new System.EventHandler(this.buttonLG_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.buttonMAX);
            this.panel1.Controls.Add(this.buttonMIN);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(231, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 51);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonMAX
            // 
            this.buttonMAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMAX.FlatAppearance.BorderSize = 0;
            this.buttonMAX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMAX.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMAX.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.buttonMAX.IconColor = System.Drawing.Color.White;
            this.buttonMAX.IconSize = 15;
            this.buttonMAX.Location = new System.Drawing.Point(1131, 0);
            this.buttonMAX.Name = "buttonMAX";
            this.buttonMAX.Rotation = 0D;
            this.buttonMAX.Size = new System.Drawing.Size(66, 51);
            this.buttonMAX.TabIndex = 0;
            this.buttonMAX.UseVisualStyleBackColor = true;
            this.buttonMAX.Click += new System.EventHandler(this.buttonMAX_Click);
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
            this.buttonMIN.Location = new System.Drawing.Point(1059, 0);
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
            this.buttonExit.Location = new System.Drawing.Point(1203, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(66, 51);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.labletime);
            this.panelmain.Controls.Add(this.pictureBox1);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(231, 51);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1269, 749);
            this.panelmain.TabIndex = 3;
            this.panelmain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmain_Paint);
            // 
            // labletime
            // 
            this.labletime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labletime.AutoSize = true;
            this.labletime.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labletime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(89)))), ((int)(((byte)(161)))));
            this.labletime.Location = new System.Drawing.Point(492, 497);
            this.labletime.Name = "labletime";
            this.labletime.Size = new System.Drawing.Size(128, 58);
            this.labletime.TabIndex = 1;
            this.labletime.Text = "TIME";
            this.labletime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::BTL_Form.Properties.Resources.petrolimex;
            this.pictureBox1.Location = new System.Drawing.Point(353, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftpanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftpanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonKH;
        private FontAwesome.Sharp.IconButton buttonHD;
        private FontAwesome.Sharp.IconButton buttonNV;
        private FontAwesome.Sharp.IconButton buttonBG;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox buttonLG;
        private FontAwesome.Sharp.IconButton buttonExit;
        private FontAwesome.Sharp.IconButton buttonMAX;
        private FontAwesome.Sharp.IconButton buttonMIN;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labletime;
        private System.Windows.Forms.Timer timer;
        private FontAwesome.Sharp.IconButton buttonBC;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using GUI.FORMS.FORM_MENU;
using DTO;
using BUS;
using Handling;
using GUI.FORMS.FORM_Màn_hình_chính;

namespace GUI.FORMS
{
    public partial class FormLogin : Form
    {
        bool signuppanel;
        public static DTOTaiKhoan DTO;
        DataTable k;
        public FormLogin()
        {
            InitializeComponent();
            //Bỏ thanh điều hướng
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //hide dang ky
            //btnSignup.Hide();


            panelSignup.Hide();
            //txtUserName
            txtUserName.Text = "Tên tài khoản";
            txtUserName.ForeColor = Color.Silver;
            //txtPassword
            txtPass.Text = "Mật khẩu";
            txtPass.ForeColor = Color.Silver;
            //txtUserNameDK
            txtUsernameDK.Text = "Nhập tên tài khoản";
            txtUsernameDK.ForeColor = Color.Silver;
            //txtPassDK
            txtPassDK.Text = "Nhập mật khẩu";
            txtPassDK.ForeColor = Color.Silver;
            //txtPassCheckDK
            txtPassCheckDK.Text = "Nhập lại mật khẩu";
            txtPassCheckDK.ForeColor = Color.Silver;
            //Hide elements in Signup Panel
            btnReturn.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            btnSignupDK.Hide();

            k = BUSTaiKhoan.showAll();

        }

        //top buttons
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }





        //
        //UserName textbox click
        //
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            txtUserName.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = SystemColors.Control;
            txtUserName.BackColor = SystemColors.Control;
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Tên tài khoản")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
                txtUserName.Focus();
            }

        }
        private void txtUserName_MouseMove(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            txtUserName.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = SystemColors.Control;
            txtUserName.BackColor = SystemColors.Control;
        }
        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Tên tài khoản")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }

        }
        //
        //Password textbox click
        //
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            txtPass.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control;
            txtPass.BackColor = SystemColors.Control;
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "Mật khẩu")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '•';
                txtPass.Focus();
            }
        }
        private void txtPass_MouseMove(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            txtPass.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void txtPass_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control;
            txtPass.BackColor = SystemColors.Control;
        }
        private void txtPass_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "Mật khẩu")
            {
                txtPass.ForeColor = Color.Black;
                txtPass.Text = "";
                txtPass.PasswordChar = '•';
            }
        }

        //
        //Signup Button
        //
        private void btnSignup_MouseMove(object sender, MouseEventArgs e)
        {
            //btnSignup.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnSignup_MouseLeave(object sender, EventArgs e)
        {
           // btnSignup.ForeColor = Color.DarkGray;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            signuppanel = false;
            panelSignup.Show();
            timer1.Start();

        }

        //
        //Timer
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (signuppanel == false)
            {
                if (panelSignup.Width < 390)
                    panelSignup.Width += 30;
                else
                    panelSignup.Width += 10;
                if (panelSignup.Width >= 458)
                {
                    timer1.Stop();
                    this.Refresh();
                    //Show elements in Signup panel
                    btnReturn.Show();
                    panel4.Show();
                    panel5.Show();
                    panel6.Show();
                    btnSignupDK.Show();
                }
            }
            else
            {
                //Hide elements in Signup panel
                btnReturn.Hide();
                panel4.Hide();
                panel5.Hide();
                panel6.Hide();
                btnSignupDK.Hide();
                if (panelSignup.Width > 100)
                    panelSignup.Width -= 30;
                else
                    panelSignup.Width -= 10;
                if (panelSignup.Width <= 0)
                {
                    timer1.Stop();
                    this.Refresh();
                   
                }
            }

        }

        //
        //Return button
        //
        private void btnReturn_Click(object sender, EventArgs e)
        {
            signuppanel = true;
            timer1.Start();

        }

        private void btnReturn_MouseMove(object sender, MouseEventArgs e)
        {
            btnReturn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnReturn_MouseLeave(object sender, EventArgs e)
        {
            btnReturn.ForeColor = Color.DarkGray;
        }

        //---------------------------------------------------------------------------------------------------------
        //
        //Signup Panel
        //

        //
        //UserNameDK textbox click
        //
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            txtUsernameDK.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;
            txtUsernameDK.BackColor = SystemColors.Control;
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            if (txtUsernameDK.Text == "Nhập tên tài khoản")
            {
                txtUsernameDK.Text = "";
                txtUsernameDK.ForeColor = Color.Black;
                txtUsernameDK.Focus();
            }

        }
        private void txtUsernameDK_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            txtUsernameDK.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void txtUsernameDK_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;
            txtUsernameDK.BackColor = SystemColors.Control;
        }
        private void txtUsernameDK_Click(object sender, EventArgs e)
        {
            if (txtUsernameDK.Text == "Nhập tên tài khoản")
            {
                txtUsernameDK.Text = "";
                txtUsernameDK.ForeColor = Color.Black;
            }

        }
        //
        //PassDK textbox click
        //
        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            txtPassDK.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = SystemColors.Control;
            txtPassDK.BackColor = SystemColors.Control;
        }
        private void panel5_Click(object sender, EventArgs e)
        {
            if (txtPassDK.Text == "Nhập mật khẩu")
            {
                txtPassDK.Text = "";
                txtPassDK.ForeColor = Color.Black;
                txtPassDK.PasswordChar = '•';
                txtPassDK.Focus();
            }
        }
        private void txtPassDK_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            txtPassDK.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void txtPassDK_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = SystemColors.Control;
            txtPassDK.BackColor = SystemColors.Control;
        }
        private void txtPassDK_Click(object sender, EventArgs e)
        {
            if (txtPassDK.Text == "Nhập mật khẩu")
            {
                txtPassDK.PasswordChar = '•';
                txtPassDK.Text = "";
                txtPassDK.ForeColor = Color.Black;
            }

        }
        //
        //PassCheckDK textbox click
        //
        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(224, 224, 224);
            txtPassCheckDK.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = SystemColors.Control;
            txtPassCheckDK.BackColor = SystemColors.Control;
        }
        private void panel6_Click(object sender, EventArgs e)
        {
            if (txtPassCheckDK.Text == "Nhập lại mật khẩu")
            {
                txtPassCheckDK.Text = "";
                txtPassCheckDK.ForeColor = Color.Black;
                txtPassCheckDK.PasswordChar = '•';
                txtPassCheckDK.Focus();
            }
        }
        private void txtPassCheckDK_MouseMove(object sender, MouseEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(224, 224, 224);
            txtPassCheckDK.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void txtPassCheckDK_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = SystemColors.Control;
            txtPassCheckDK.BackColor = SystemColors.Control;
        }
        private void txtPassCheckDK_Click(object sender, EventArgs e)
        {
            if (txtPassCheckDK.Text == "Nhập lại mật khẩu")
            {
                txtPassCheckDK.PasswordChar = '•';
                txtPassCheckDK.Text = "";
                txtPassCheckDK.ForeColor = Color.Black;
            }

        }


        //
        //-----------------------------------------------------------------------------------
        //
        //
        //Sign In Button
        //
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="" || txtPass.Text == "")
            {
                labelTB.Text = "Hãy điền đủ thông tin !";
            }
            else
            {
                string t = txtUserName.Text;
                string m = txtPass.Text;
                DataTable k= BUSTaiKhoan.TaiKhoan(t, m);
               
                if (k.Rows.Count == 0) labelTB.Text = "Sai tài khoản hoặc mật khẩu !";
                else
                {
                    List<DTOTaiKhoan> dtoTK = Handling.HandlingContent.ConvertDataTable<DTOTaiKhoan>(k);
                    DTO = dtoTK.First();
                    if (DTO.Quyen == "admin")
                    {

                    }
                    else
                    {
                        
                    }
                    Form1 f1 = new Form1();
                    //Form1.btnQLTK.Enabled = false;


                    this.Hide();
                    //ActiveForm.Close();
                    f1.Show();
                    //this.Close();
                }
            }
            
                     
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMK f1 = new FormQuenMK();
            f1.ShowDialog();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }

}

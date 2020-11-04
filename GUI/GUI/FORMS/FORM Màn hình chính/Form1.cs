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
using GUI.FORMS;
using GUI.FORMS.FORM_IN_BG;
using GUI.FORMS.FORM_MENU;

namespace GUI
{
    public partial class Form1 : Form
    {
        bool userslide;
        private IconButton currentBtn;
        private Panel leftBorderbtn;
        private Form currentchildform;

        public Form1()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7,75);
            leftpanel.Controls.Add(leftBorderbtn);

            //Bỏ thanh điều hướng
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        //Menu Button
        private void PressedButton(object senderBtn)
        {
            if(senderBtn != null)
            {
                UnpressedButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(54,89,161);
                //left border button
                leftBorderbtn.BackColor = Color.White;
                leftBorderbtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();
            }
        }

        private void UnpressedButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(56, 65, 83);

            }
        }


        //child form
        private void openchildform(Form childform)
        {
            if(currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelmain.Controls.Add(childform);
            panelmain.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            labletime.Text = DateTime.Now.ToLongTimeString();
            userslide = false;
            iconTop.Hide();
            lbUsername.Text = FormLogin.DTO.TenNguoiDung;
            lbEmail.Text = FormLogin.DTO.Email;
        }

        private void buttonBG_Click(object sender, EventArgs e)
        {
            iconTop.Show();
            iconTop.IconChar = IconChar.Burn;
            PressedButton(sender);
            openchildform(new FormSP());
        }

        private void buttonNV_Click(object sender, EventArgs e)
        {
            iconTop.Show();
            iconTop.IconChar = IconChar.Male;
            PressedButton(sender);
            openchildform(new FormNV());

        }

        private void buttonHD_Click(object sender, EventArgs e)
        {
            iconTop.Show();
            iconTop.IconChar = IconChar.Barcode;
            PressedButton(sender);
            openchildform(new FormHD());

        }

        private void buttonKH_Click(object sender, EventArgs e)
        {
            iconTop.Show();
            iconTop.IconChar = IconChar.Shopify;
            PressedButton(sender);
            openchildform(new FormKH());

        }
        private void buttonBC_Click(object sender, EventArgs e)
        {
            iconTop.Show();
            iconTop.IconChar = IconChar.Check;
            PressedButton(sender);
            openchildform(new FormBC());
        }

        private void buttonLG_Click(object sender, EventArgs e)
        {
            if(currentchildform == null)
            {

            }
            else
            {
                currentchildform.Close();
                iconTop.Hide();
                Reset();
            }
        }

        private void Reset()
        {
            UnpressedButton();
            leftBorderbtn.Visible = false;
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


        //top buttons
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonMAX_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }


        //timer
        private void timer_Tick(object sender, EventArgs e)
        {
            labletime.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {  
            timer1.Start();
            if (userslide)
                btnUser.IconChar = IconChar.AngleDoubleUp;
            else
                btnUser.IconChar = IconChar.AngleDoubleDown;
        }

        //timer for user slide
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!userslide)
            {
                panel2.Height += 10;
                if(panel2.Height >= 256)
                {
                    timer1.Stop();
                    userslide = true;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Height -= 10;
                if(panel2.Height <= 96)
                {
                    timer1.Stop();
                    userslide = false;
                    this.Refresh();
                }
            }
        }

        //Nut dang xuat
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var openformLogin = new FormLogin();
            this.Hide();
            // ActiveForm.Close();
            openformLogin.ShowDialog();
            this.Close();
        }

        //Nut doi mat khau
        private void btnDoiMK_MouseMove(object sender, MouseEventArgs e)
        {
            btnDoiMK.ForeColor = Color.DarkGray;
        }

        private void btnDoiMK_MouseLeave(object sender, EventArgs e)
        {
            btnDoiMK.ForeColor = Color.Gray;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            var openformChangePass = new FormChangePass();
            openformChangePass.ShowDialog();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            var openformQLTK = new FormQLTK();
            openformQLTK.ShowDialog();
        }


        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            iconTop.Show();
            iconTop.IconChar = IconChar.HospitalUser;
            PressedButton(sender);
            openchildform(new FormChiTiet());

        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            iconTop.Show();
            iconTop.IconChar = IconChar.Shopify;
            PressedButton(sender);
            openchildform(new FormNCC());
        }

        
    }
}

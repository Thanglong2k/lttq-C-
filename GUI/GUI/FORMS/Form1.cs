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
using BTL_Form.FORMS;

namespace BTL_Form
{
    public partial class Form1 : Form
    {
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
        }

        private void buttonBG_Click(object sender, EventArgs e)
        {
            PressedButton(sender);
            openchildform(new FormBG());
        }

        private void buttonNV_Click(object sender, EventArgs e)
        {
            PressedButton(sender);
            openchildform(new FormNV());

        }

        private void buttonHD_Click(object sender, EventArgs e)
        {
            PressedButton(sender);
            openchildform(new FormHD());

        }

        private void buttonKH_Click(object sender, EventArgs e)
        {
            PressedButton(sender);
            openchildform(new FormKH());

        }
        private void buttonBC_Click(object sender, EventArgs e)
        {
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
    }
}

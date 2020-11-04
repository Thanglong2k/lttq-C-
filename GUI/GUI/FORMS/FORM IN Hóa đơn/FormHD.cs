using GUI.FORMS.FORM_IN_HD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormHD : Form
    {
        private Button currentBtnHD;
        private Form currentchildformHD;
        public FormHD()
        {
            InitializeComponent();
        }

        //BG button
        private void PressedButtonHD(object senderBtn)
        {
            if (senderBtn != null)
                UnpressedButtonHD();
            {
                currentBtnHD = (Button)senderBtn;
                currentBtnHD.BackColor = Color.FromArgb(54, 89, 161);
                currentBtnHD.ForeColor = Color.White;
            }
        }
        private void UnpressedButtonHD()
        {
            if (currentBtnHD != null)
            {
                currentBtnHD.BackColor = SystemColors.Control;
                currentBtnHD.ForeColor = Color.FromArgb(54, 89, 161);
            }
        }


        //child form
        private void openchildformHD(Form childform)
        {
            if (currentchildformHD != null)
            {
                currentchildformHD.Close();
            }
            currentchildformHD = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelHD.Controls.Add(childform);
            panelHD.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void FormHD_Load(object sender, EventArgs e)
        {
            //hide nut tim kiem
            btnTimKiem.Hide();


            btnHDB.BackColor = Color.FromArgb(54, 89, 161);
            btnHDB.ForeColor = Color.White;
            openchildformHD(new FormHDB());
        }

        private void btnHDB_Click(object sender, EventArgs e)
        {
            PressedButtonHD(sender);
            openchildformHD(new FormHDB());
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            PressedButtonHD(sender);
            openchildformHD(new FormHDN());
            btnHDB.BackColor = SystemColors.Control;
            btnHDB.ForeColor = Color.FromArgb(54, 89, 161);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            PressedButtonHD(sender);
            openchildformHD(new FormHDTK());
            btnHDB.BackColor = SystemColors.Control;
            btnHDB.ForeColor = Color.FromArgb(54, 89, 161);
        }
    }
}

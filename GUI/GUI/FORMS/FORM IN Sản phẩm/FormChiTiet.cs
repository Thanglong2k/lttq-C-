using GUI.FORMS.FORM_IN_Sản_phẩm.FORM_IN_Chi_tiết;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORMS.FORM_IN_BG
{
    public partial class FormChiTiet : Form
    {
        private Button currentBtnHD;
        private Form currentchildformHD;
        public FormChiTiet()
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
            panelMain.Controls.Add(childform);
            panelMain.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void FormChiTiet_Load(object sender, EventArgs e)
        {
            btnLoaiGa.BackColor = Color.FromArgb(54, 89, 161);
            btnLoaiGa.ForeColor = Color.White;
            openchildformHD(new FormLoaiGa());
        }

        private void btnLoaiGa_Click(object sender, EventArgs e)
        {
            PressedButtonHD(sender);
            openchildformHD(new FormLoaiGa());
        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            PressedButtonHD(sender);
            openchildformHD(new FormMau());
            btnLoaiGa.BackColor = SystemColors.Control;
            btnLoaiGa.ForeColor = Color.FromArgb(54, 89, 161);
        }

        private void btnKhoiLuong_Click(object sender, EventArgs e)
        {
            PressedButtonHD(sender);
            openchildformHD(new FormKhoiLuongcs());
            btnLoaiGa.BackColor = SystemColors.Control;
            btnLoaiGa.ForeColor = Color.FromArgb(54, 89, 161);
        }

        private void btnNuocSX_Click(object sender, EventArgs e)
        {
            PressedButtonHD(sender);
            openchildformHD(new FormNuocSX());
            btnLoaiGa.BackColor = SystemColors.Control;
            btnLoaiGa.ForeColor = Color.FromArgb(54, 89, 161);
        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {
            PressedButtonHD(sender);
            openchildformHD(new FormCaLam());
            btnLoaiGa.BackColor = SystemColors.Control;
            btnLoaiGa.ForeColor = Color.FromArgb(54, 89, 161);
        }

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            PressedButtonHD(sender);
            openchildformHD(new FormCongViec());
            btnLoaiGa.BackColor = SystemColors.Control;
            btnLoaiGa.ForeColor = Color.FromArgb(54, 89, 161);
        }
    }
    
}

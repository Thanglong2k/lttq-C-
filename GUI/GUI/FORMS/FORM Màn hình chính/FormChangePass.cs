using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using FontAwesome.Sharp;

namespace GUI.FORMS
{
    public partial class FormChangePass : Form
    {
        public FormChangePass()
        {
            InitializeComponent();
        }

        
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //
        //OldPass textbox click
        //
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            txtOldPass.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;
            txtOldPass.BackColor = SystemColors.Control;
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "Nhập mật khẩu cũ")
            {
                txtOldPass.Text = "";
                txtOldPass.ForeColor = Color.Black;
                txtOldPass.Focus();
            }

        }
        private void txtOldPass_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            txtOldPass.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void txtOldPass_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;
            txtOldPass.BackColor = SystemColors.Control;
        }
        private void txtOldPass_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "Nhập mật khẩu cũ")
            {
                txtOldPass.Text = "";
                txtOldPass.ForeColor = Color.Black;
            }

        }
        //
        //PassDK textbox click
        //
        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            txtNewPass.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = SystemColors.Control;
            txtNewPass.BackColor = SystemColors.Control;
        }
        private void panel5_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "Nhập mật khẩu mới")
            {
                txtNewPass.Text = "";
                txtNewPass.ForeColor = Color.Black;
                txtNewPass.PasswordChar = '•';
                txtNewPass.Focus();
            }
        }
        private void txtNewPass_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            txtNewPass.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void txtNewPass_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = SystemColors.Control;
            txtNewPass.BackColor = SystemColors.Control;
        }
        private void txtNewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "Nhập mật khẩu mới")
            {
                txtNewPass.PasswordChar = '•';
                txtNewPass.Text = "";
                txtNewPass.ForeColor = Color.Black;
            }

        }
        //
        //PassCheckDK textbox click
        //
        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(224, 224, 224);
            txtNewPassCheck.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = SystemColors.Control;
            txtNewPassCheck.BackColor = SystemColors.Control;
        }
        private void panel6_Click(object sender, EventArgs e)
        {
            if (txtNewPassCheck.Text == "Nhập lại mật khẩu mới")
            {
                txtNewPassCheck.Text = "";
                txtNewPassCheck.ForeColor = Color.Black;
                txtNewPassCheck.PasswordChar = '•';
                txtNewPassCheck.Focus();
            }
        }
        private void txtNewPassCheck_MouseMove(object sender, MouseEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(224, 224, 224);
            txtNewPassCheck.BackColor = Color.FromArgb(224, 224, 224);
        }
        private void txtNewPassCheck_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = SystemColors.Control;
            txtNewPassCheck.BackColor = SystemColors.Control;
        }
        private void txtNewPassCheck_Click(object sender, EventArgs e)
        {
            if (txtNewPassCheck.Text == "Nhập lại mật khẩu mới")
            {
                txtNewPassCheck.PasswordChar = '•';
                txtNewPassCheck.Text = "";
                txtNewPassCheck.ForeColor = Color.Black;
            }

        }

        private void FormChangePass_Load(object sender, EventArgs e)
        {
            //txtOldPass
            txtOldPass.Text = "Nhập mật khẩu cũ";
            txtOldPass.ForeColor = Color.Silver;
            //txtNewPass
            txtNewPass.Text = "Nhập mật khẩu mới";
            txtNewPass.ForeColor = Color.Silver;
            //txtNewPassCheck
            txtNewPassCheck.Text = "Nhập lại mật khẩu mới";
            txtNewPassCheck.ForeColor = Color.Silver;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if(txtOldPass.Text == "" || txtNewPass.Text=="" || txtNewPassCheck.Text == "")
            {
                lbTB.Text = "Hãy nhập đầy đủ thông tin !";
            }
            else
            {
                if(txtOldPass.Text != FormLogin.DTO.MatKhau)
                {
                    lbTB.Text = "Mật khẩu cũ không đúng !";
                }
                else
                {
                    if (txtNewPass.Text != txtNewPassCheck.Text)
                    {
                        lbTB.Text = "Mật khẩu nhập lại không khớp !";
                    }
                    else
                    {
                        string tk = FormLogin.DTO.TaiKhoan;
                        string mk = txtNewPass.Text;
                        BUSTaiKhoan.UpdateMK(tk, mk);
                        this.Close();
                    }
                }
            }
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

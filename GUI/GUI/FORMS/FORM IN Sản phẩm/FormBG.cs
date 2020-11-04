using GUI.FORMS.FORM_IN_BG;
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
    public partial class FormBG : Form
    {
        private Button currentBtnBG;
        private Form currentchildformBG;
        public FormBG()
        {
            InitializeComponent();
        }

        //BG button
        private void PressedButtonBG(object senderBtn)
        {
            if (senderBtn != null)
                UnpressedButtonBG();
            {
                currentBtnBG = (Button)senderBtn;
                currentBtnBG.BackColor = Color.FromArgb(54, 89, 161);
                currentBtnBG.ForeColor = Color.White;
            }
        }
        private void UnpressedButtonBG()
        {
            if (currentBtnBG != null)
            {
                currentBtnBG.BackColor = SystemColors.Control;
                currentBtnBG.ForeColor = Color.FromArgb(54, 89, 161);
            }
        }


        //child form
        private void openchildformBG(Form childform)
        {
            if (currentchildformBG != null)
            {
                currentchildformBG.Close();
            }
            currentchildformBG = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelSP.Controls.Add(childform);
            panelSP.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void FormBG_Load(object sender, EventArgs e)
        {
            buttonSP.BackColor = Color.FromArgb(54, 89, 161);
            buttonSP.ForeColor = Color.White;
            openchildformBG(new FormSP());
        }

        private void buttonSP_Click(object sender, EventArgs e)
        {
            PressedButtonBG(sender);
            openchildformBG(new FormSP());
        }

        private void buttonTK1_Click(object sender, EventArgs e)
        {
            PressedButtonBG(sender);
            openchildformBG(new FormTK1());
            buttonSP.BackColor = SystemColors.Control;
            buttonSP.ForeColor = Color.FromArgb(54, 89, 161);
        }
    }
}

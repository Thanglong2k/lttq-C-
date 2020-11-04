using GUI.FORMS.FORM_IN_BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORMS
{
    public partial class FormBC : Form
    {
        private Form currentchildform;
        public FormBC()
        {
            InitializeComponent();
        }

        private void FormBC_Load(object sender, EventArgs e)
        {

            
        }
        //child form
        private void openchildform(Form childform)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childform;
            childform.AutoScroll = false;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childform);
            panelMain.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void cbBCSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBCSelection.SelectedIndex == 0)
            {
                openchildform(new FormBC1());
            }
            if(cbBCSelection.SelectedIndex == 1)
            {
                openchildform(new FormBC2());
            }
            if(cbBCSelection.SelectedIndex == 2)
            {
                openchildform(new FormBC3());
            }
            if (cbBCSelection.SelectedIndex == 3)
            {
                openchildform(new FormBC4());
            }
        }
    }
}

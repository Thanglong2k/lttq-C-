using BUS;
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
    public partial class FormTK1 : Form
    {
        public FormTK1()
        {
            InitializeComponent();
        }

        public void FillCbo(string nameTB, ComboBox cbo, string ma, string ten)
        {

            cbo.DataSource = BUSBinhGa.showAll(nameTB);
            cbo.ValueMember = ma;//giá trị lấy xuống
            cbo.DisplayMember = ten;
            cbo.SelectedIndex = -1;
        }

        private void FormTK1_Load(object sender, EventArgs e)
        {
            FillCbo("BinhGa", cbLoaiTK1, "MaLoai", "TenLoai");
           
        }
    }
}

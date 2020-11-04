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

namespace GUI.FORMS.FORM_IN_HD
{
    public partial class FormTKHD : Form
    {
        FormHDN hdn = new FormHDN();
        DataGridView data;
        public FormTKHD(DataGridView dt)
        {
            InitializeComponent();
            data = dt;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTKHD_Load(object sender, EventArgs e)
        {
            chbNgayNhap.Checked = false;
            dtpNgayNhap.Visible = false;
            FillCbo("BinhGa", cbMaBinh, "MaBinh", "TenBinh");
            FillCbo("NhaCungCap", cbNhaCC, "MaNCC", "TenNCC");
        }

        private void btnTimTK1_Click(object sender, EventArgs e)
        {
            DataView dataView = BUSHDNhap.showAllHDN_CTHDN().DefaultView;
           
            if (cbMaBinh.SelectedIndex == -1 && cbNhaCC.SelectedIndex == -1 && chbNgayNhap.Checked == false)

            {
                MessageBox.Show("Hãy nhập thông tin cần tìm!");
            }
            else
            {
                string maBinh = "";
                if (cbMaBinh.SelectedIndex != -1)
                    maBinh = cbMaBinh.Text;
                string ncc = "";
                if (cbNhaCC.SelectedIndex!=-1)
                    ncc = cbNhaCC.SelectedValue.ToString();
                


                string Filter = "";
                if (!string.IsNullOrEmpty(maBinh))
                {
                    Filter += "MaBinh like '" + maBinh + "' AND ";
                }
                if (!string.IsNullOrEmpty(ncc))
                {
                    Filter += "MaNCC like '" + ncc + "' AND ";
                }
                if (chbNgayNhap.Checked==true)
                {
                    DateTime date = Convert.ToDateTime(dtpNgayNhap.Value.ToString("yyyy/MM/dd"));
                    
                    
                    Filter += "NgayNhap = '" + date + "' AND ";
                }

                Filter = Filter.Remove(Filter.Length - 4, 3);
                dataView.RowFilter = Filter;

            }


            DataTable s = dataView.ToTable();
            data.DataSource = s;
            data.Refresh();

            this.Close();
        }

        private void chbNgayNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNgayNhap.Checked == true)
            {
                dtpNgayNhap.Visible = true;
            }
            else
            {
                dtpNgayNhap.Visible = false;
            }
        }


        public void FillCbo(string nameTB, ComboBox cbo, string ma, string ten)
        {

            cbo.DataSource = BUSBinhGa.showAll(nameTB);
            cbo.ValueMember = ma;//giá trị lấy xuống
            cbo.DisplayMember = ten;
            cbo.SelectedIndex = -1;
        }
    }
}

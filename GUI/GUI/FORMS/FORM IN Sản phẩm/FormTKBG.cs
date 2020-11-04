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
    public partial class FormTKBG : Form
    {   
        FormSP sp=new FormSP();
        public FormTKBG()
        {
            InitializeComponent();
        }

        DataGridView data;
        public FormTKBG(DataGridView dt)
        {
            InitializeComponent();
            data = dt;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimTK1_Click(object sender, EventArgs e)
        {
            /*int dem = -1;
            if (cbLoaiTK1.SelectedIndex != -1)
            {
                var dt = ((DataTable)data.DataSource).Copy();
                for (int i = 0; i < data.Rows.Count; i++)
                //foreach(DataGridViewRow s in data.Rows)
                {
                    //if(s.Cells[2].Value!=null && s.Cells[2].Value.ToString()== cbLoaiTK1.SelectedValue.ToString())
                    
                    if (cbLoaiTK1.SelectedValue.ToString()!=data.Rows[i].Cells[2].Value.ToString())
                    {
                        data.Rows.RemoveAt(i);
                        dem=i;
                        //txtBaoHanhTK1.Text = "a";
                        //break;
                    }
                    
                }
                if (dem == -1)
                {
                    
                        txtBaoHanhTK1.Text = cbLoaiTK1.SelectedValue.ToString();
                        //txtMaLoaiTK1.Text = data.Rows[dem].Cells[2].Value.ToString();
                    
                }
                this.Close();
            }*/
            DataView dataView = BUSBinhGa.showAll("BinhGa").DefaultView;
            if (cbLoaiTK1.Text=="" && cbKLTK1.Text=="" && txtBHTK1.Text == "")
            {
                MessageBox.Show("Hãy nhập thông tin cần tìm!");
            }
            else
            {
                string loai="";
                if (cbLoaiTK1.SelectedIndex != -1)
                {
                    loai = cbLoaiTK1.SelectedValue.ToString();
                }
                          
                string kl = cbKLTK1.Text;
                string bh = txtBHTK1.Text;
                

                string Filter = "";
                if (!string.IsNullOrEmpty(loai))
                {
                    Filter += "MaLoai like '" + loai + "' AND ";
                }
                if (!string.IsNullOrEmpty(kl))
                {
                    Filter += "MaKL = " + kl + " AND ";
                }
                if (txtBHTK1.Text!="")
                {
                    Filter += "ThoiGianBaoHanh = " + bh + " AND ";
                }
                
                    Filter = Filter.Remove(Filter.Length - 4, 3);
                    dataView.RowFilter = Filter;
                
            }
            
            
            DataTable s = dataView.ToTable();
            data.DataSource = s;
            data.Refresh();

            this.Close();
        }

        private void FormTKBG_Load(object sender, EventArgs e)
        {
            FillCbo("LoaiGa", cbLoaiTK1, "MaLoai", "TenLoai");
            FillCbo("KhoiLuong", cbKLTK1, "MaKL", "MaKL");
            
        }
        public void FillCbo(string nameTB, ComboBox cbo, string ma, string ten)
        {

            cbo.DataSource = BUSBinhGa.showAll(nameTB);
            cbo.ValueMember = ma;//giá trị lấy xuống
            cbo.DisplayMember = ten;
            cbo.SelectedIndex = -1;
        }



        private void txtBHTK1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
            if (txtBHTK1.TextLength == 1 && !Char.IsControl(e.KeyChar))           
                e.Handled = true;
                
            
        }
    }
}

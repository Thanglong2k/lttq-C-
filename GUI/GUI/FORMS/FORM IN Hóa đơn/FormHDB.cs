using BUS;
using DTO;
using GUI.QLGADataSetTableAdapters;
using Handling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORMS.FORM_IN_HD
{
    public partial class FormHDB : Form
    {
        DTOBinhGa binhGa;
        List<DTOChiTietHDB> ListCTHDB = new List<DTOChiTietHDB>();//lưu cthdb trong 1 hoa don
        //List<DTOBinhGa> ListBinhGa = new List<DTOBinhGa>();//lư
        DataTable t,k;
        private int index = -1;
        public FormHDB()
        {
            InitializeComponent();
        }

        private void FormHDB_Load(object sender, EventArgs e)
        {
            t = BUSBinhGa.showAll("BinhGa");
            k = BUSChiTIetHDB.showAll();
            dataGridViewHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHDB.DataSource = BUSHDBan.showAll("HoaDonBan");
            FillCbo("NhanVien", cbMaNV, "MaNV", "TenNV");
            FillCbo("KhachHang", cbMaKhach, "MaKH", "TenKH");
            FillCbo("BinhGa", cbBinhGa, "MaBinh", "TenBinh");
            LoadPage();

        }
        public void FillCbo(string nameTB, ComboBox cbo, string ma, string ten)
        {

            cbo.DataSource = BUSBinhGa.showAll(nameTB);
            cbo.ValueMember = ma;//giá trị lấy xuống
            cbo.DisplayMember = ten;
            cbo.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            DTOHDBan hdb = new DTOHDBan(txtSoHDB.Text, cbMaNV.SelectedValue.ToString(), dtpNgayBan.Value, cbMaKhach.SelectedValue.ToString(), long.Parse(txtTongTien.Text));
            if (!BUSHDBan.Add(hdb))
            {
                MessageBox.Show("Lưu hóa đơn không thành công");
            }
            else
            {
                foreach(DTOChiTietHDB ct in ListCTHDB)
                {
                    //DTOChiTietHDB cthdb = new DTOChiTietHDB(ct.SoHDB, ct.MaBinh, ct.SoLuong, ct.GiamGia, ct.ThanhTien);
                    BUSChiTIetHDB.Add(ct);
                    
                    
                }
                MessageBox.Show("Lưu thành công");

                dataGridViewHDB.DataSource = BUSHDBan.showAll("HoaDonBan");

                LoadPage();
                
            }
        }

        private void btnXoaHDB_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {

                dataGridViewHDB2.Rows.RemoveAt(index);
                ListCTHDB.RemoveAt(index);

            }
            else
            {
                MessageBox.Show("Hãy chọn mục bạn muốn xóa");
            }
        }

        private void btnThemHDB_Click(object sender, EventArgs e)
        {
            if (ktraTrungLap() == false)
            {
                MessageBox.Show("Bình ga đã được chọn trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadPage1();
                return;
            }
            else
            {
                //Truy vấn
                /* var ketqua = from kq in ListBinhGa
                              where kq.MaBinh.StartsWith(cbBinhGa.SelectedValue.ToString())
                              select kq.SoLuong;*/

                binhGa = HandlingContent.CreateItemFromRow<DTOBinhGa>(Enumberable(t, cbBinhGa, "MaBinh")[0]);
                //var binhGa = ListBinhGa.FirstOrDefault(x => x.MaBinh == cbBinhGa.SelectedValue.ToString());
                if (binhGa != null)
                {
                    long remain = binhGa.SoLuong - int.Parse(txtSoLuong.Text);
                    if (remain < 0)
                    {
                        MessageBox.Show("Bình Ga " + binhGa.TenBinh + " chỉ có " + binhGa.SoLuong + " bình");
                        txtSoLuong.Text = "";
                        return;
                    }

                }
                dataGridViewHDB2.Visible = true;
                DTOChiTietHDB cthdb = new DTOChiTietHDB(txtSoHDB.Text, cbBinhGa.SelectedValue.ToString(), int.Parse(txtSoLuong.Text),
                    int.Parse(txtGiamGia.Text), long.Parse(txtThanhTien.Text));
                ListCTHDB.Add(cthdb);
                //ListBinhGa.Add(binhGa);
                dataGridViewHDB2.Rows.Add(txtSoHDB.Text, cbBinhGa.SelectedValue.ToString(), int.Parse(txtSoLuong.Text),
                    int.Parse(txtGiamGia.Text), long.Parse(txtThanhTien.Text));
                TinhTongTien();
                lbThanhChu.Text = Handling.HandlingChuoiTien.ChuyenSoSangChuoi(double.Parse(txtTongTien.Text));
                LoadPage1();
            }
        }
        private void btnSuaHDB_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                long remain = binhGa.SoLuong - int.Parse(txtSoLuong.Text);
                if (remain < 0)
                {
                    MessageBox.Show("Bình Ga " + binhGa.TenBinh + " chỉ có " + binhGa.SoLuong + " bình");
                    txtSoLuong.Text = "";
                    return;
                }

                var ga = ListCTHDB.FirstOrDefault(ct => ct.MaBinh == cbBinhGa.SelectedValue.ToString());
                ga.SoLuong = int.Parse(txtSoLuong.Text);
                ga.GiamGia = int.Parse(txtGiamGia.Text);
                ga.ThanhTien = long.Parse(txtThanhTien.Text);
                txtTongTien.Text = (long.Parse(txtTongTien.Text) - long.Parse(dataGridViewHDB2.Rows[index].Cells["ThanhTien"].Value.ToString())).ToString();
                foreach (DataGridViewRow dataRow in dataGridViewHDB2.Rows)
                {
                    if (dataRow.Cells["MaBinh"].Value == cbBinhGa.SelectedValue.ToString())
                    {
                        dataRow.Cells["SoLuong"].Value = ga.SoLuong.ToString();
                        dataRow.Cells["GiamGia"].Value = ga.GiamGia.ToString();
                        dataRow.Cells["ThanhTien"].Value = ga.ThanhTien.ToString();
                    }
                }
                
                TinhTongTien();
                lbThanhChu.Text = Handling.HandlingChuoiTien.ChuyenSoSangChuoi(double.Parse(txtTongTien.Text));
                LoadPage1();

            }
            else
            {
                MessageBox.Show("Hãy chọn mục bạn muốn xóa");
            }
        }
        private void dataGridViewHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;//lấy vị trí hàng được click
                DataGridViewRow selectRow = dataGridViewHDB.Rows[index];
                txtSoHDB.Text = selectRow.Cells[0].Value.ToString();
                cbMaNV.SelectedValue = selectRow.Cells[1].Value.ToString();
                dtpNgayBan.Text = selectRow.Cells[2].Value.ToString();
                cbMaKhach.SelectedValue = selectRow.Cells[3].Value.ToString();
                txtTongTien.Text = selectRow.Cells[4].Value.ToString();
                lbThanhChu.Text = Handling.HandlingChuoiTien.ChuyenSoSangChuoi(double.Parse(txtTongTien.Text));
            }
            catch { }

            
        }

        

        public bool ktraTrungLap()
        {
            int count = 0;
            foreach (DTOChiTietHDB cthdb in ListCTHDB)
            {
                if (cthdb.MaBinh == cbBinhGa.Text)
                {
                    count++;
                }
            }
            return count == 0 ? true : false;
        }
        private void LoadPage()
        {
            txtGiamGia.Text = "0";
            txtSoLuong.Text = "0";
            txtTongTien.Text = "0";
            txtThanhTien.Text = "0";
            cbMaKhach.SelectedIndex = -1;
            cbMaNV.SelectedIndex = -1;
            cbBinhGa.SelectedIndex = -1;
        }
        private void LoadPage1()
        {
            txtGiamGia.Text = "0";
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";
            cbBinhGa.SelectedIndex = -1;
        }
        private void TinhThanhTien()
        {
            DTOBinhGa binhGa = HandlingContent.CreateItemFromRow<DTOBinhGa>(Enumberable(t, cbBinhGa, "MaBinh")[0]);
            long tien;
            if (txtSoLuong.Text == "")
            {
                tien = 0;
            }
            else
            {
                if (txtGiamGia.Text == "")
                {
                    tien = int.Parse(txtSoLuong.Text) * binhGa.DonGiaBan;
                }
                else
                {
                    tien = (long)(int.Parse(txtSoLuong.Text) * binhGa.DonGiaBan* ((1- 1.0f * int.Parse(txtGiamGia.Text)/100))) ;
                }
            }
            
            txtThanhTien.Text = tien.ToString();
        }

        private void TinhTongTien()
        {
            float tong = long.Parse(txtTongTien.Text);
            tong+= long.Parse(txtThanhTien.Text);
            txtTongTien.Text = tong.ToString();
        }

    

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }



        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void btnThemHDM_Click(object sender, EventArgs e)
        {
            if (ListCTHDB.Count != 0)
            {
                DialogResult kq = MessageBox.Show("Huy don ?", "Thong bao", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes) ListCTHDB.Clear();
                else return;
            }
            txtSoHDB.Text = Handling.HandlingDateTime.taochuoiDateTime("HDB");
            ListCTHDB.Clear();
            
        }

        private void dataGridViewHDB_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewHDB2.Visible = true;
            dataGridViewHDB.Visible = false;
            LoadPage1();
            DataRow[] dataRows = Enumberable1(k, e, "SoHDB");
            foreach (DataRow dr in dataRows)
            {
                DTOChiTietHDB cthdb = HandlingContent.CreateItemFromRow<DTOChiTietHDB>(dr);
                dataGridViewHDB2.Rows.Add(cthdb.SoHDB,cthdb.MaBinh,cthdb.SoLuong,cthdb.GiamGia,cthdb.ThanhTien);
            }
            
        }

        private DataRow[] Enumberable(DataTable dt, ComboBox cb,string s)
        {
            IEnumerable<DataRow> query = dt.AsEnumerable().Where
                 (
                     row =>
                     (
                        cb.SelectedIndex == -1 ? true : row.Field<string>(s).Contains(cb.SelectedValue.ToString())
                     )

                 );
            DataTable o = query.CopyToDataTable<DataRow>();
            DataRow[] u = o.Select();
            return u;
        }

        private void dataGridViewHDB2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewHDB2.Rows.Clear();
            dataGridViewHDB.Visible = true;
            dataGridViewHDB2.Visible = false;
        }

        private void dataGridViewHDB2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;//lấy vị trí hàng được click
                DataGridViewRow selectRow = dataGridViewHDB2.Rows[index];
                txtSoHDB.Text = selectRow.Cells[0].Value.ToString();
                cbBinhGa.SelectedValue = selectRow.Cells[1].Value.ToString();
                txtSoLuong.Text = selectRow.Cells[2].Value.ToString();
                txtGiamGia.Text = selectRow.Cells[3].Value.ToString();
                txtThanhTien.Text = selectRow.Cells[4].Value.ToString();
            }
            catch { }
        }

        

        private DataRow[] Enumberable1(DataTable dt, DataGridViewCellEventArgs dv, string s)
        {
            int i = dv.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = dataGridViewHDB.Rows[index];
            IEnumerable<DataRow> query = dt.AsEnumerable().Where
                 (
                     row =>
                     (
                        i == -1 ? true : row.Field<string>(s).Contains(selectRow.Cells[0].Value.ToString())
                     )

                 ); ;
            DataTable o = query.CopyToDataTable<DataRow>();
            DataRow[] u = o.Select();
            return u;
        }
    }
}

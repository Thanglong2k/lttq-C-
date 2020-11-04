using BUS;
using DTO;
using Handling;
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
    public partial class FormHDN : Form
    {
        List<DTOChiTietHDN> ListCTHDN = new List<DTOChiTietHDN>();//lưu cthdb trong 1 hoa don
        private int index = -1;
        DataTable t, k;
        public FormHDN()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var openformTKHD = new FormTKHD(dataGridViewHDN);
            openformTKHD.ShowDialog();
        }
        public void FillCbo(string nameTB, ComboBox cbo, string ma, string ten)
        {

            cbo.DataSource = BUSBinhGa.showAll(nameTB);
            cbo.ValueMember = ma;//giá trị lấy xuống
            cbo.DisplayMember = ten;
            cbo.SelectedIndex = -1;
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormHDN_Load(object sender, EventArgs e)
        {
            t = BUSBinhGa.showAll("BinhGa");
            k = BUSChiTietHDN.showAll();
            dataGridViewHDN.Visible = true;
            dataGridViewHDN2.Visible = false;
            dataGridViewHDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHDN.DataSource = BUSHDNhap.showAll();
            FillCbo("NhanVien", cbMaNV, "MaNV", "TenNV");
            FillCbo("NhaCungCap", cbNhaCC, "MaNCC", "TenNCC");
            FillCbo("BinhGa", cbBinhGa, "MaBinh", "TenBinh");
            LoadPage();
        }

        private void btnThemHDN_Click(object sender, EventArgs e)
        {
            if (ktraTrungLap() == false)
            {
                MessageBox.Show("Bình ga đã được chọn trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadPage1();
                return;
            }
            else
            {               
                dataGridViewHDN2.Visible = true;
                DTOChiTietHDN cthdn = new DTOChiTietHDN(txtSoHDN.Text, cbBinhGa.SelectedValue.ToString(), int.Parse(txtSoLuong.Text),
                    long.Parse(txtDonGia.Text),int.Parse(txtGiamGia.Text), long.Parse(txtThanhTien.Text));
                ListCTHDN.Add(cthdn);
                //ListBinhGa.Add(binhGa);
                dataGridViewHDN2.Rows.Add(txtSoHDN.Text, cbBinhGa.SelectedValue.ToString(), int.Parse(txtSoLuong.Text),
                    long.Parse(txtDonGia.Text), int.Parse(txtGiamGia.Text), long.Parse(txtThanhTien.Text));
                TinhTongTien();
                lbThanhChu.Text = Handling.HandlingChuoiTien.ChuyenSoSangChuoi(double.Parse(txtTongTien.Text));
                LoadPage1();
            }
            
        }



        public bool ktraTrungLap()
        {
            int count = 0;
            foreach (DTOChiTietHDN cthdn in ListCTHDN)
            {
                if (cthdn.MaBinh == cbBinhGa.Text)
                {
                    count++;
                }
            }
            return count == 0 ? true : false;
        }
        private void LoadPage()
        {
            txtDonGia.Text = "0";
            txtGiamGia.Text = "0";
            txtSoLuong.Text = "0";
            txtTongTien.Text = "0";
            txtThanhTien.Text = "0";
            cbNhaCC.SelectedIndex = -1;
            cbMaNV.SelectedIndex = -1;
            cbBinhGa.SelectedIndex = -1;
        }
        private void TinhTongTien()
        {
            float tong = long.Parse(txtTongTien.Text);
            tong += long.Parse(txtThanhTien.Text);
            txtTongTien.Text = tong.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTOHDNhap hdn = new DTOHDNhap(txtSoHDN.Text, cbMaNV.SelectedValue.ToString(), dtpNgayNhap.Value, cbNhaCC.SelectedValue.ToString(), long.Parse(txtTongTien.Text));
            if (!BUSHDNhap.Add(hdn))
            {
                MessageBox.Show("Lưu hóa đơn không thành công");
            }
            else
            {
                foreach (DTOChiTietHDN ct in ListCTHDN)
                {
                    //DTOChiTietHDB cthdb = new DTOChiTietHDB(ct.SoHDB, ct.MaBinh, ct.SoLuong, ct.GiamGia, ct.ThanhTien);
                    BUSChiTietHDN.Add(ct);


                }
                MessageBox.Show("Lưu thành công");

                dataGridViewHDN.DataSource = BUSHDBan.showAll("HoaDonBan");

                LoadPage();

            }
        }

        private void btnThemHDM_Click(object sender, EventArgs e)
        {
            if (ListCTHDN.Count != 0)
            {
                DialogResult kq = MessageBox.Show("Huy don ?", "Thong bao", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes) ListCTHDN.Clear();
                else return;
            }
            txtSoHDN.Text = Handling.HandlingDateTime.taochuoiDateTime("HDN");
            ListCTHDN.Clear();
        }

        private void btnSuaHDN_Click(object sender, EventArgs e)
        {

            var ga = ListCTHDN.FirstOrDefault(ct => ct.MaBinh == cbBinhGa.SelectedValue.ToString());
            ga.SoLuong = int.Parse(txtSoLuong.Text);
            ga.GiamGia = int.Parse(txtGiamGia.Text);
            ga.ThanhTien = long.Parse(txtThanhTien.Text);
            txtTongTien.Text = (long.Parse(txtTongTien.Text) - long.Parse(dataGridViewHDN2.Rows[index].Cells["ThanhTien"].Value.ToString())).ToString();
            foreach (DataGridViewRow dataRow in dataGridViewHDN2.Rows)
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

        private void btnXoaHDN_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {

                dataGridViewHDN2.Rows.RemoveAt(index);
                ListCTHDN.RemoveAt(index);

            }
            else
            {
                MessageBox.Show("Hãy chọn mục bạn muốn xóa");
            }
        }

        private void LoadPage1()
        {
            txtDonGia.Text = "0";
            txtGiamGia.Text = "0";
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";
            cbBinhGa.SelectedIndex = -1;
        }
        private DataRow[] Enumberable(DataTable dt, ComboBox cb, string s)
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

        private void dataGridViewHDN2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;//lấy vị trí hàng được click
                DataGridViewRow selectRow = dataGridViewHDN2.Rows[index];
                txtSoHDN.Text = selectRow.Cells[0].Value.ToString();
                cbBinhGa.SelectedValue = selectRow.Cells[1].Value.ToString();
                txtSoLuong.Text = selectRow.Cells[2].Value.ToString();
                txtDonGia.Text = selectRow.Cells["DonGia"].Value.ToString();
                txtGiamGia.Text = selectRow.Cells[4].Value.ToString();
                txtThanhTien.Text = selectRow.Cells["ThanhTien"].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewHDN2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewHDN2.Rows.Clear();
            dataGridViewHDN.Visible = true;
            dataGridViewHDN2.Visible = false;
        }

        private DataRow[] Enumberable1(DataTable dt, DataGridViewCellEventArgs dv, string s)
        {
            int i = dv.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = dataGridViewHDN.Rows[index];
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

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void dataGridViewHDN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewHDN2.Visible = true;
            dataGridViewHDN.Visible = false;
            LoadPage1();
            DataRow[] dataRows = Enumberable1(k, e, "SoHDN");
            foreach (DataRow dr in dataRows)
            {
                DTOChiTietHDN cthdn = HandlingContent.CreateItemFromRow<DTOChiTietHDN>(dr);
                dataGridViewHDN2.Rows.Add(cthdn.SoHDN, cthdn.MaBinh, cthdn.SoLuong, cthdn.DonGia, cthdn.GiamGia, cthdn.ThanhTien);
            }
        }

        private void dataGridViewHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;//lấy vị trí hàng được click
                DataGridViewRow selectRow = dataGridViewHDN.Rows[index];
                txtSoHDN.Text = selectRow.Cells[0].Value.ToString();
                cbMaNV.SelectedValue = selectRow.Cells[1].Value.ToString();
                dtpNgayNhap.Text = selectRow.Cells[2].Value.ToString();
                cbNhaCC.SelectedValue = selectRow.Cells[3].Value.ToString();
                txtTongTien.Text = selectRow.Cells[4].Value.ToString();
                lbThanhChu.Text = Handling.HandlingChuoiTien.ChuyenSoSangChuoi(double.Parse(txtTongTien.Text));
            }
            catch { }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dialog= MessageBox.Show("Bạn có chắc chắn muốn hủy", "Hủy", MessageBoxButtons.YesNo);
            if (dialog== DialogResult.Yes)
            {
                LoadPage();
                txtSoHDN.Text = "";
                dataGridViewHDN2.Rows.Clear();
                ListCTHDN.Clear();
            }
            
        }

        private void TinhThanhTien()
        {          
            long tien;
            if (txtSoLuong.Text == "" || txtDonGia.Text=="")
            {
                tien = 0;
            }
            else
            {
                if (txtGiamGia.Text == "")
                {
                    tien = int.Parse(txtSoLuong.Text) * long.Parse(txtDonGia.Text);
                }
                else
                {
                    tien = (long)(int.Parse(txtSoLuong.Text) * long.Parse(txtDonGia.Text) * ((1 - 1.0f * int.Parse(txtGiamGia.Text) / 100)));
                }
            }

            txtThanhTien.Text = tien.ToString();
        }
    }
}

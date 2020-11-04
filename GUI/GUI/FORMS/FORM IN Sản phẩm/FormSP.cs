using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORMS.FORM_IN_BG
{
    public partial class FormSP : Form
    {
        
        private int index = -1;
        public FormSP()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var openformLogin = new FormTKBG(dataGridViewSP);
            openformLogin.ShowDialog();
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var openformChiTiet = new FormChiTiet();
            openformChiTiet.ShowDialog();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (checkData() == 1)
            {
                MessageBox.Show("Bạn chưa nhập đúng dữ liệu");
            }
            else
            {


                DTOBinhGa binhGa = new DTOBinhGa(txtMaBinh.Text, txtTenBinh.Text, cbLoai.SelectedValue.ToString(), cbMau.SelectedValue.ToString(), int.Parse(cbKhoiLuong.Text), cbNSX.SelectedValue.ToString(),
                    int.Parse(txtSoLuong.Text), long.Parse(txtNhap.Text), long.Parse(txtBan.Text), int.Parse(txtBaoHanh.Text), ImgToByte(picboxSP.Image), txtGhichu.Text);
                if (!BUSBinhGa.Add(binhGa))
                {
                    MessageBox.Show("Thêm ko thành công");
                }
                else
                {

                    MessageBox.Show("Thêm thành công");
                    dataGridViewSP.DataSource = BUSBinhGa.showAll("BinhGa");


                    LoadPage();
                }
            }
        }

        private byte[] converImgToByte()
        {
            FileStream fs;
            fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;

        }

        private byte[] ImgToByte(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);
            return ms.ToArray();
        }
        private Image ByteToImg(byte[] imgBytes)
        {
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            open.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            open.FilterIndex = 1;//vị trí filter được chọn
            open.Title = "Chọn ảnh";
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                picboxSP.SizeMode = PictureBoxSizeMode.StretchImage;
                //picboxSP.Image = ByteToImg(converImgToByte());            
                picboxSP.ImageLocation = open.FileName;
            }
        }

        private void FormSP_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridViewSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSP.DataSource = BUSBinhGa.showAll("BinhGa");
            FillCbo("LoaiGa", cbLoai, "MaLoai", "TenLoai");
            FillCbo("Mau", cbMau, "MaMau", "TenMau");
            FillCbo("NuocSX", cbNSX, "MaNSX", "TenNSX");
            FillCbo("KhoiLuong", cbKhoiLuong, "MaKL", "TenKL");
            
        }
        public void FillCbo(string nameTB, ComboBox cbo, string ma, string ten)
        {

            cbo.DataSource = BUSBinhGa.showAll(nameTB);
            cbo.ValueMember = ma;//giá trị lấy xuống
            cbo.DisplayMember = ten;
            cbo.SelectedIndex = -1;
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Hãy chọn đối tượng bạn muốn sửa!");
            }
            else
            {
                if (!dataGridViewSP.Rows[index].Cells[0].Value.ToString().Equals(txtMaBinh.Text))
                {
                    txtMaBinh.Text = dataGridViewSP.Rows[index].Cells[0].Value.ToString();
                    MessageBox.Show("Bạn không được sửa mã bình!");
                }
                else
                {
                    if (checkData() == 1)
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đã sửa sai!");
                    }
                    else
                    {
                        DTOBinhGa binhGa = new DTOBinhGa(txtMaBinh.Text, txtTenBinh.Text, cbLoai.SelectedValue.ToString(), cbMau.SelectedValue.ToString(), int.Parse(cbKhoiLuong.Text), cbNSX.SelectedValue.ToString(),
                            int.Parse(txtSoLuong.Text), long.Parse(txtNhap.Text), long.Parse(txtBan.Text), int.Parse(txtBaoHanh.Text), ImgToByte(picboxSP.Image), txtGhichu.Text);
                        if (index != -1)
                        {
                            if (!BUSBinhGa.Edit(binhGa))
                            {
                                MessageBox.Show("Sửa ko thành công");
                            }
                            else
                            {
                                MessageBox.Show("Sửa thành công");
                                dataGridViewSP.DataSource = BUSBinhGa.showAll("BinhGa");

                                LoadPage();

                            }
                        }
                    }
                }
            }
        }

        private void dataGridViewSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;//lấy vị trí hàng được click
                DataGridViewRow selectRow = dataGridViewSP.Rows[index];
                txtMaBinh.Text = selectRow.Cells[0].Value.ToString();
                txtTenBinh.Text = selectRow.Cells[1].Value.ToString();
                cbLoai.SelectedValue = selectRow.Cells[2].Value.ToString();
                cbMau.SelectedValue = selectRow.Cells[3].Value.ToString();
                cbKhoiLuong.SelectedValue = selectRow.Cells[4].Value.ToString();
                cbNSX.SelectedValue = selectRow.Cells[5].Value.ToString();
                txtSoLuong.Text = selectRow.Cells[6].Value.ToString();
                txtNhap.Text = selectRow.Cells[7].Value.ToString();
                txtBan.Text = selectRow.Cells[8].Value.ToString();
                txtBaoHanh.Text = selectRow.Cells[9].Value.ToString();
                txtGhichu.Text = selectRow.Cells[11].Value.ToString();
                if (selectRow.Cells[10].Value != DBNull.Value)
                {
                    Byte[] anh = (Byte[])selectRow.Cells[10].Value;
                    picboxSP.Image = ByteToImg(anh);
                    picboxSP.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    picboxSP.Image = null;
                }
                

            }
            catch
            {
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (index != -1)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridViewSP.Rows[index];
                string ID = row.Cells[0].Value.ToString();

                // Xóa
                if (!BUSBinhGa.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {

                    MessageBox.Show("Xóa thành công");
                    dataGridViewSP.DataSource = BUSBinhGa.showAll("BinhGa"); // refresh datagridview

                    LoadPage();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn mục bạn muốn xóa");
            }
        }

        private void LoadPage()
        {
            txtMaBinh.Text = "";
            txtTenBinh.Text = "";
            cbLoai.SelectedIndex = -1;
            cbMau.SelectedIndex = -1;
            cbKhoiLuong.SelectedIndex = -1;
            cbNSX.SelectedIndex = -1;
            txtSoLuong.Text = "";
            txtNhap.Text = "";
            txtBan.Text = "";
            txtBaoHanh.Text = "";
            txtGhichu.Text = "";
        }
        private int checkData()
        {
            int t = 0,i;
            
            if (txtMaBinh.Text=="")
            {
                checkMaBinh.Text = "X";
                checkMaBinh.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMaBinh, "Bạn chưa nhập mã bình!");
                t = 1;
            }
            else
            {
                checkMaBinh.Text = "";
            }
            if (txtTenBinh.Text == "")
            {
                checkTenBinh.Text = "X";
                checkTenBinh.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkTenBinh, "Bạn chưa nhập tên bình!");
                t = 1;
            }
            else
            {
                checkTenBinh.Text = "";
            }
            if (txtBaoHanh.Text== "")
            {
                checkBaoHanh.Text = "X";
                checkBaoHanh.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkBaoHanh, "Bạn chưa nhập bảo hành!");
                t = 1;
            }
            else
            {
                if(!int.TryParse(txtBaoHanh.Text,out i))
                {
                    checkBaoHanh.Text = "X";
                    checkBaoHanh.ForeColor = Color.Red;
                    toolTip1.SetToolTip(checkBaoHanh, "Bạn nhập sai định dạng!");
                    t = 1;
                }
                else
                {
                    checkBaoHanh.Text = "";
                }
            }
            if (cbLoai.SelectedIndex == -1)
            {
                checkLoai.Text = "X";
                checkLoai.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkLoai, "Bạn chưa chọn loại ga!");
                t = 1;
            }
            else
            {
                checkLoai.Text = "";
            }
            if (cbKhoiLuong.SelectedIndex == -1)
            {
                checkKhoiLuong.Text = "X";
                checkKhoiLuong.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkKhoiLuong, "Bạn chưa chọn khối lượng!");
                t = 1;
            }
            else
            {
                checkKhoiLuong.Text = "";
            }
            if (txtGhichu.Text=="")
            {
                checkGhiChu.Text = "X";
                checkGhiChu.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkGhiChu, "Bạn chưa nhập ghi chú!");
                t = 1;
            }
            else
            {
                checkGhiChu.Text = "";
            }
            if (cbMau.SelectedIndex == -1)
            {
                checkMau.Text = "X";
                checkMau.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMau, "Bạn chưa chọn màu bình ga!");
                t = 1;
            }
            else
            {
                checkMau.Text = "";
            }
            if (cbNSX.SelectedIndex == -1)
            {
                checkNSX.Text = "X";
                checkNSX.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkNSX, "Bạn chưa chọn nước sản xuất!");
                t = 1;
            }
            else
            {
                checkNSX.Text = "";
            }
            if (t == 1) return 1;
            else
            {
                return 0;
            }
            
        }
        private void loadLabelCheck()
        {
            checkMaBinh.Text = "";
            checkTenBinh.Text = "";
            checkMau.Text = "";
            checkLoai.Text = "";
            checkKhoiLuong.Text = "";
            checkBaoHanh.Text = "";
            checkGhiChu.Text = "";
            checkNSX.Text = "";
        }
    }
    
}

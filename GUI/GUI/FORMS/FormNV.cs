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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormNV : Form
    {
        
        private int index = -1;
        public FormNV()
        {
            InitializeComponent();
        }
          

        private void FormNV_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridViewNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNV.DataSource = BUSNhanVien.showAll("NhanVien");
            FillCbo("CaLam", cbCa, "MaCa", "TenCa");
            FillCbo("CongViec", cbCongViec, "MaCV", "TenCV");
            
        }

        public void FillCbo(string nameTB, ComboBox cbo, string ma, string ten)
        {
            
            cbo.DataSource = BUSNhanVien.showAll(nameTB);
            cbo.ValueMember = ma;//giá trị lấy xuống
            cbo.DisplayMember = ten;
            cbo.SelectedIndex = -1;
        }

        private void LoadPage()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cbCa.SelectedIndex = -1;
            cbCongViec.SelectedIndex = -1;           
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            rbNam.Checked = true;
        }

        private string checkGT()
        {  
            if (rbNam.Checked == true) return "Nam";
            else return "Nữ";
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (checkData() == 1)
            {
                MessageBox.Show("Bạn chưa nhập đúng dữ liệu");
            }
            else
            {
                DTONhanVien nhanVien = new DTONhanVien(txtMaNV.Text, txtTenNV.Text, checkGT(), DateTime.Parse(dtpNgaySinh.Text),
                txtDienThoai.Text, txtDiaChi.Text, int.Parse(cbCa.SelectedValue.ToString()), cbCongViec.SelectedValue.ToString());
                if (!BUSNhanVien.Add(nhanVien))
                {
                    MessageBox.Show("Thêm ko thành công");
                }
                else
                {

                    MessageBox.Show("Thêm thành công");
                    dataGridViewNV.DataSource = BUSBinhGa.showAll("NhanVien");
                    LoadPage();
                }
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {

            if (index == -1)
            {
                MessageBox.Show("Hãy chọn đối tượng bạn muốn sửa!");
            }
            else
            {
                if (!dataGridViewNV.Rows[index].Cells[0].Value.ToString().Equals(txtMaNV.Text))
                {
                    MessageBox.Show("Bạn không được sửa mã nhân viên!");
                }
                else
                {
                    if (checkData() == 1)
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đã sửa sai!");
                    }
                    else
                    {
                        DTONhanVien nhanVien = new DTONhanVien(txtMaNV.Text, txtTenNV.Text, checkGT(), DateTime.Parse(dtpNgaySinh.Text),
                   txtDienThoai.Text, txtDiaChi.Text, int.Parse(cbCa.SelectedValue.ToString()), cbCongViec.SelectedValue.ToString());
                        if (!BUSNhanVien.Edit(nhanVien))
                        {
                            MessageBox.Show("Sửa ko thành công");
                        }
                        else
                        {

                            MessageBox.Show("Sửa thành công");
                            dataGridViewNV.DataSource = BUSBinhGa.showAll("NhanVien");
                            LoadPage();
                        }
                    }
                   
                }
                
            }
            
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridViewNV.Rows[index];
                string ID = row.Cells[0].Value.ToString();

                // Xóa
                if (!BUSNhanVien.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {

                    MessageBox.Show("Xóa thành công");
                    dataGridViewNV.DataSource = BUSBinhGa.showAll("NhanVien"); // refresh datagridview

                    LoadPage();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn đối tượng bạn muốn xóa!");
            }
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;//lấy vị trí hàng được click
                DataGridViewRow selectRow = dataGridViewNV.Rows[index];
                txtMaNV.Text = selectRow.Cells[0].Value.ToString();
                txtTenNV.Text = selectRow.Cells[1].Value.ToString();
                if (selectRow.Cells[2].Value.ToString().Equals("Nam"))
                {
                    rbNam.Checked = true;
                }
                else rbNu.Checked = true;               
                
                dtpNgaySinh.Value = DateTime.Parse(selectRow.Cells[3].Value.ToString());
                txtDienThoai.Text = selectRow.Cells[4].Value.ToString();
                txtDiaChi.Text = selectRow.Cells[5].Value.ToString();
                cbCa.SelectedValue = selectRow.Cells[6].Value.ToString();
                cbCongViec.SelectedValue = selectRow.Cells[7].Value.ToString();               
            }
            catch
            {
            }
        }
        private int checkData()
        {
            int t = 0;
            if (txtMaNV.Text == "")
            {
                checkMaNV.Text = "X";
                checkMaNV.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMaNV, "Bạn chưa nhập mã nhân viên!");
                t = 1;
            }
            else
            {
                checkMaNV.Text = "";
            }
            if (txtTenNV.Text == "")
            {
                checkTenNV.Text = "X";
                checkTenNV.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkTenNV, "Bạn chưa nhập tên nhân viên!");
                t = 1;
            }
            else
            {
                checkTenNV.Text = "";
            }
            if (txtDiaChi.Text == "")
            {
                checkDiaChi.Text = "X";
                checkDiaChi.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkDiaChi, "Bạn chưa nhập địa chỉ!");
                t = 1;
            }
            else
            {
                checkDiaChi.Text = "";                
            }
            
            if (txtDienThoai.Text == "")
            {
                checkDT.Text = "X";
                checkDT.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkDT, "Bạn chưa nhập điện thoại!");
                t = 1;
            }
            else
            {
                if (IsPhoneNumber(txtDienThoai.Text) == false)
                {
                    checkDT.Text = "X";
                    checkDT.ForeColor = Color.Red;
                    toolTip1.SetToolTip(checkDT, "Bạn nhập sai định dạng điện thoại!");
                    t = 1;
                }
                else
                {
                    checkDT.Text = "";
                }
               
            }
            if (cbCa.SelectedIndex == -1)
            {
                checkCaLam.Text = "X";
                checkCaLam.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkCaLam, "Bạn chưa chọn ca làm!");
                t = 1;
            }
            else
            {
                checkCaLam.Text = "";
            }
            if (cbCongViec.SelectedIndex == -1)
            {
                checkCongViec.Text = "X";
                checkCongViec.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkCongViec, "Bạn chưa chọn công việc!");
                t = 1;
            }
            else
            {
                checkCongViec.Text = "";
            }
            if (t == 1) return 1;
            else
            {
                return 0;
            }

        }
        private bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(0[0-9]{9})$").Success;
        }
        private void loadLabelCheck()
        {
            checkCaLam.Text = "";
            checkCongViec.Text = "";
            checkDiaChi.Text = "";
            checkDT.Text = "";
            checkMaNV.Text = "";
            checkTenNV.Text = "";
            
        }
    }
}

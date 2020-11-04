using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORMS
{
    public partial class FormNCC : Form
    {
        private int index = -1;
        public FormNCC()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkData() == 1)
            {
                MessageBox.Show("Bạn chưa nhập đúng dữ liệu");
            }
            else
            {
                DTONhaCungCap NCC = new DTONhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtDienThoai.Text);
                if (!BUSNhaCungCap.Add(NCC))
                {
                    MessageBox.Show("Thêm ko thành công");
                }
                else
                {

                    MessageBox.Show("Thêm thành công");
                    dataGridViewNCC.DataSource = BUSNhaCungCap.showAll();
                    LoadPage();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Hãy chọn đối tượng bạn muốn sửa!");
            }
            else
            {
                if (!dataGridViewNCC.Rows[index].Cells[0].Value.ToString().Equals(txtMaNCC.Text))
                {
                    MessageBox.Show("Bạn không được sửa mã nhà cung cấp!");
                }
                else
                {
                    if (checkData() == 1)
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đã sửa sai!");
                    }
                    else
                    {
                        DTONhaCungCap NCC = new DTONhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtDienThoai.Text);
                        if (!BUSNhaCungCap.Edit(NCC))
                        {
                            MessageBox.Show("Sửa ko thành công");
                        }
                        else
                        {

                            MessageBox.Show("Sửa thành công");
                            dataGridViewNCC.DataSource = BUSNhaCungCap.showAll();
                            LoadPage();
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridViewNCC.Rows[index];
                string ID = row.Cells[0].Value.ToString();

                // Xóa
                if (!BUSNhaCungCap.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridViewNCC.DataSource = BUSNhaCungCap.showAll(); // refresh datagridview

                    LoadPage();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn đối tượng bạn muốn xóa!");
            }
        }

        private void LoadPage()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridViewNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNCC.DataSource = BUSNhaCungCap.showAll();
        }

        private void dataGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = dataGridViewNCC.Rows[index];
            txtTenNCC.Text = selectRow.Cells[1].Value.ToString();
            txtMaNCC.Text = selectRow.Cells[0].Value.ToString();
            txtDienThoai.Text = selectRow.Cells[3].Value.ToString();
            txtDiaChi.Text = selectRow.Cells[2].Value.ToString();
        }
        private int checkData()
        {
            int t = 0;

            if (txtMaNCC.Text == "")
            {
                checkMaNCC.Text = "X";
                checkMaNCC.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMaNCC, "Bạn chưa nhập mã nhà cung cấp!");
                t = 1;
            }
            else
            {
                checkMaNCC.Text = "";
            }
            if (txtTenNCC.Text == "")
            {
                checkTenNCC.Text = "X";
                checkTenNCC.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkTenNCC, "Bạn chưa nhập tên nhà cung cấp!");
                t = 1;
            }
            else
            {
                checkTenNCC.Text = "";
            }
            if (txtDiaChi.Text == "")
            {
                checkDC.Text = "X";
                checkDC.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkDC, "Bạn chưa nhập địa chỉ!");
                t = 1;
            }
            else
            {
                checkDC.Text = "";

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

            if (t == 1) return 1;
            else
            {
                return 0;
            }

        }
        private void loadLabelCheck()
        {
            checkMaNCC.Text = "";
            checkTenNCC.Text = "";
            checkDT.Text = "";
            checkDC.Text = "";

        }
        private bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(0[0-9]{9})$").Success;
        }
    }
}

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
    public partial class FormKH : Form
    {
        private int index = -1;
        public FormKH()
        {
            InitializeComponent();
        }

        private void btnThemHDB_Click(object sender, EventArgs e)
        {
            if (checkData() == 1)
            {
                MessageBox.Show("Bạn chưa nhập đúng dữ liệu");
            }
            else
            {
                DTOKhachHang KH = new DTOKhachHang(txtMaKhach.Text, txtTenKhach.Text, txtDiaChi.Text, txtDienThoai.Text);
                if (!BUSKhachHang.Add(KH))
                {
                    MessageBox.Show("Thêm ko thành công");
                }
                else
                {

                    MessageBox.Show("Thêm thành công");
                    dataGridViewKH.DataSource = BUSKhachHang.showAll();
                    LoadPage();
                }
            }
            
        }

        private void btnSuaHDB_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Hãy chọn đối tượng bạn muốn sửa!");
            }
            else
            {
                if (!dataGridViewKH.Rows[index].Cells[0].Value.ToString().Equals(txtMaKhach.Text))
                {
                    MessageBox.Show("Bạn không được sửa mã khách hàng!");
                }
                else
                {
                    if (checkData() == 1)
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đã sửa sai!");
                    }
                    else
                    {
                        DTOKhachHang KH = new DTOKhachHang(txtMaKhach.Text, txtTenKhach.Text, txtDiaChi.Text, txtDienThoai.Text);
                        if (!BUSKhachHang.Edit(KH))
                        {
                            MessageBox.Show("Sửa ko thành công");
                        }
                        else
                        {

                            MessageBox.Show("Sửa thành công");
                            dataGridViewKH.DataSource = BUSKhachHang.showAll();
                            LoadPage();
                        }
                    }
                }
            }
        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridViewKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKH.DataSource = BUSKhachHang.showAll();
            
        }

        private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = dataGridViewKH.Rows[index];
            txtTenKhach.Text = selectRow.Cells[1].Value.ToString();
            txtMaKhach.Text = selectRow.Cells[0].Value.ToString();
            txtDienThoai.Text = selectRow.Cells[3].Value.ToString();
            txtDiaChi.Text = selectRow.Cells[2].Value.ToString();

        }
        private void LoadPage()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";           
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";           
        }
        private int checkData()
        {
            int t = 0;
      
            if (txtMaKhach.Text == "")
            {
                checkMaKhach.Text = "X";
                checkMaKhach.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMaKhach, "Bạn chưa nhập mã khách!");
                t = 1;
            }
            else
            {
                checkMaKhach.Text = "";
            }
            if (txtTenKhach.Text == "")
            {
                checkTenKhach.Text = "X";
                checkTenKhach.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkTenKhach, "Bạn chưa nhập tên khách!");
                t = 1;
            }
            else
            {
                checkTenKhach.Text = "";
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
            checkMaKhach.Text = "";
            checkTenKhach.Text = "";
            checkDT.Text = "";
            checkDC.Text = "";
            
        }
        private bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(0[0-9]{9})$").Success;
        }

        private void btnXoaHDB_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridViewKH.Rows[index];
                string ID = row.Cells[0].Value.ToString();

                // Xóa
                if (!BUSKhachHang.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {                                                                                                                                                                                                                                                                                                                                                                                                                                           
                    MessageBox.Show("Xóa thành công");
                    dataGridViewKH.DataSource = BUSKhachHang.showAll(); // refresh datagridview

                    LoadPage();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn đối tượng bạn muốn xóa!");
            }
        }
    }
}

using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORMS.FORM_IN_Sản_phẩm.FORM_IN_Chi_tiết
{
    public partial class FormNuocSX : Form
    {
        private int index = -1;
        public FormNuocSX()
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
                DTONuocSX nsx = new DTONuocSX(txtMaNuocSX.Text, txtTenNuocSX.Text);

                if (!BUSNuocSX.Add(nsx))
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewNSX.DataSource = BUSNuocSX.showAll();

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
                if (!dataGridViewNSX.Rows[index].Cells[0].Value.ToString().Equals(txtMaNuocSX.Text))
                {
                    txtMaNuocSX.Text = dataGridViewNSX.Rows[index].Cells[0].Value.ToString();
                    MessageBox.Show("Bạn không được sửa mã nước sản xuất!");
                }
                else
                {
                    if (checkData() == 1)
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đã sửa sai!");
                    }
                    else
                    {
                        DTONuocSX nsx = new DTONuocSX(txtMaNuocSX.Text, txtTenNuocSX.Text);

                        if (!BUSNuocSX.Edit(nsx))
                        {
                            MessageBox.Show("Sửa không thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thành công");
                            dataGridViewNSX.DataSource = BUSNuocSX.showAll();

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

                DataGridViewRow row = dataGridViewNSX.Rows[index];
                string ID = row.Cells[0].Value.ToString();

                // Xóa
                if (!BUSNuocSX.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {

                    MessageBox.Show("Xóa thành công");
                    dataGridViewNSX.DataSource = BUSNuocSX.showAll(); // refresh datagridview

                    LoadPage();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn mục bạn muốn xóa");
            }
        }

        private void dataGridViewNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = dataGridViewNSX.Rows[index];
            txtMaNuocSX.Text = selectRow.Cells[0].Value.ToString();
            txtTenNuocSX.Text = selectRow.Cells[1].Value.ToString();
        }

        private void FormNuocSX_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridViewNSX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewNSX.DataSource = BUSNuocSX.showAll();
        }
        private void LoadPage()
        {
            txtMaNuocSX.Text = "";
            txtTenNuocSX.Text = "";

        }
        private int checkData()
        {
            int t = 0;

            if (txtMaNuocSX.Text == "")
            {
                checkMaNSX.Text = "X";
                checkMaNSX.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMaNSX, "Bạn chưa nhập mã nước sản xuất!");
                t = 1;
            }
            else
            {
                checkMaNSX.Text = "";
            }
            if (txtTenNuocSX.Text == "")
            {
                checkTenNSX.Text = "X";
                checkTenNSX.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkTenNSX, "Bạn chưa nhập tên nước sản xuất!");
                t = 1;
            }
            else
            {
                checkTenNSX.Text = "";
            }

            if (t == 1) return 1;
            else
            {
                return 0;
            }

        }
        private void loadLabelCheck()
        {
            checkTenNSX.Text = "";
            checkMaNSX.Text = "";

        }
    }
}

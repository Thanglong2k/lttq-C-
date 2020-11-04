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
    public partial class FormCongViec : Form
    {
        private int index = -1;
        public FormCongViec()
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
                DTOCongViec cv = new DTOCongViec(txtMaCV.Text, txtTenCV.Text);

                if (!BUSCongViec.Add(cv))
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewCV.DataSource = BUSCongViec.showAll();

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
                if (!dataGridViewCV.Rows[index].Cells[0].Value.ToString().Equals(txtMaCV.Text))
                {
                    txtMaCV.Text = dataGridViewCV.Rows[index].Cells[0].Value.ToString();
                    MessageBox.Show("Bạn không được sửa mã công việc!");
                }
                else
                {
                    if (checkData() == 1)
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đã sửa sai!");
                    }
                    else
                    {
                        DTOCongViec cv = new DTOCongViec(txtMaCV.Text, txtTenCV.Text);

                        if (!BUSCongViec.Edit(cv))
                        {
                            MessageBox.Show("Sửa không thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thành công");
                            dataGridViewCV.DataSource = BUSCongViec.showAll();

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

                DataGridViewRow row = dataGridViewCV.Rows[index];
                string ID = row.Cells[0].Value.ToString();

                // Xóa
                if (!BUSCongViec.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {

                    MessageBox.Show("Xóa thành công");
                    dataGridViewCV.DataSource = BUSCongViec.showAll(); // refresh datagridview

                    LoadPage();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn mục bạn muốn xóa");
            }
        }

        private void FormCongViec_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridViewCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCV.DataSource = BUSCongViec.showAll();
        }

        private void dataGridViewCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = dataGridViewCV.Rows[index];
            txtMaCV.Text = selectRow.Cells[0].Value.ToString();   
            txtTenCV.Text = selectRow.Cells[1].Value.ToString();
        }

        private void LoadPage()
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            
        }
        private int checkData()
        {
            int t = 0;

            if (txtMaCV.Text == "")
            {
                checkMaCV.Text = "X";
                checkMaCV.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMaCV, "Bạn chưa nhập mã công việc!");
                t = 1;
            }
            else
            {
                checkMaCV.Text = "";
            }
            if (txtTenCV.Text == "")
            {
                checkTenCV.Text = "X";
                checkTenCV.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkTenCV, "Bạn chưa nhập tên công việc!");
                t = 1;
            }
            else
            {
                checkTenCV.Text = "";
            }

            if (t == 1) return 1;
            else
            {
                return 0;
            }

        }
        private void loadLabelCheck()
        {
            checkTenCV.Text = "";
            checkMaCV.Text = "";

        }
    }
}

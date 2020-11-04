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
    public partial class FormMau : Form
    {
        private int index = -1;
        public FormMau()
        {
            InitializeComponent();
        }

        private void FormMau_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridViewMau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMau.DataSource = BUSMau.showAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkData() == 1)
            {
                MessageBox.Show("Bạn chưa nhập đúng dữ liệu");
            }
            else
            {
                DTOMau mau = new DTOMau(txtMaMau.Text, txtTenMau.Text);

                if (!BUSMau.Add(mau))
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewMau.DataSource = BUSMau.showAll();

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
                if (!dataGridViewMau.Rows[index].Cells[0].Value.ToString().Equals(txtMaMau.Text))
                {
                    txtMaMau.Text = dataGridViewMau.Rows[index].Cells[0].Value.ToString();
                    MessageBox.Show("Bạn không được sửa mã màu!");
                }
                else
                {
                    if (checkData() == 1)
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đã sửa sai!");
                    }
                    else
                    {
                        DTOMau mau = new DTOMau(txtMaMau.Text, txtTenMau.Text);

                        if (!BUSMau.Edit(mau))
                        {
                            MessageBox.Show("Sửa không thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thành công");
                            dataGridViewMau.DataSource = BUSMau.showAll();

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

                DataGridViewRow row = dataGridViewMau.Rows[index];
                string ID = row.Cells[0].Value.ToString();

                // Xóa
                if (!BUSMau.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {

                    MessageBox.Show("Xóa thành công");
                    dataGridViewMau.DataSource = BUSMau.showAll(); // refresh datagridview

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
            txtMaMau.Text = "";
            txtTenMau.Text = "";

        }

        private void dataGridViewMau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = dataGridViewMau.Rows[index];
            txtMaMau.Text = selectRow.Cells[0].Value.ToString();
            txtTenMau.Text = selectRow.Cells[1].Value.ToString();
        }
        private int checkData()
        {
            int t = 0;

            if (txtMaMau.Text == "")
            {
                checkMaMau.Text = "X";
                checkMaMau.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMaMau, "Bạn chưa nhập mã màu!");
                t = 1;
            }
            else
            {
                checkMaMau.Text = "";
            }
            if (txtTenMau.Text == "")
            {
                checkMau.Text = "X";
                checkMau.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMau, "Bạn chưa nhập tên màu!");
                t = 1;
            }
            else
            {
                checkMau.Text = "";
            }
           
            if (t == 1) return 1;
            else
            {
                return 0;
            }

        }
        private void loadLabelCheck()
        {
            checkMaMau.Text = "";
            checkMau.Text = "";
            
        }
    }
}

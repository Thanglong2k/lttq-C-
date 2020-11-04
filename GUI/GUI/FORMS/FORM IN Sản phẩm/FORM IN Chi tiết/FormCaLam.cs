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
    public partial class FormCaLam : Form
    {
        private int index = -1;
        public FormCaLam()
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
                DTOCaLam ca = new DTOCaLam(txtMaCa.Text, txtTenCa.Text);

                if (!BUSCaLam.Add(ca))
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewCL.DataSource = BUSCaLam.showAll();

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
                if (!dataGridViewCL.Rows[index].Cells[0].Value.ToString().Equals(txtMaCa.Text))
                {
                    txtMaCa.Text = dataGridViewCL.Rows[index].Cells[0].Value.ToString();
                    MessageBox.Show("Bạn không được sửa mã ca làm!");
                }
                else
                {
                    if (checkData() == 1)
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đã sửa sai!");
                    }
                    else
                    {
                        DTOCaLam ca = new DTOCaLam(txtMaCa.Text, txtTenCa.Text);

                        if (!BUSCaLam.Edit(ca))
                        {
                            MessageBox.Show("Sửa không thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thành công");
                            dataGridViewCL.DataSource = BUSCaLam.showAll();

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

                DataGridViewRow row = dataGridViewCL.Rows[index];
                string ID = row.Cells[0].Value.ToString();

                // Xóa
                if (!BUSCaLam.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {

                    MessageBox.Show("Xóa thành công");
                    dataGridViewCL.DataSource = BUSCaLam.showAll(); // refresh datagridview

                    LoadPage();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn mục bạn muốn xóa");
            }
        }

        private void FormCaLam_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridViewCL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCL.DataSource = BUSCaLam.showAll();
        }

        private void dataGridViewCL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = dataGridViewCL.Rows[index];
            txtMaCa.Text = selectRow.Cells[0].Value.ToString();
            txtTenCa.Text = selectRow.Cells[1].Value.ToString();
        }
        private void LoadPage()
        {
            txtMaCa.Text = "";
            txtTenCa.Text = "";

        }
        private int checkData()
        {
            int t = 0;

            if (txtMaCa.Text == "")
            {
                checkMaCa.Text = "X";
                checkMaCa.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMaCa, "Bạn chưa nhập mã ca!");
                t = 1;
            }
            else
            {
                checkMaCa.Text = "";
            }
            if (txtTenCa.Text == "")
            {
                checkTenCa.Text = "X";
                checkTenCa.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkTenCa, "Bạn chưa nhập tên ca!");
                t = 1;
            }
            else
            {
                checkTenCa.Text = "";
            }
           
            if (t == 1) return 1;
            else
            {
                return 0;
            }

        }
        private void loadLabelCheck()
        {
            checkMaCa.Text = "";
            checkTenCa.Text = "";
            
        }
    }
}

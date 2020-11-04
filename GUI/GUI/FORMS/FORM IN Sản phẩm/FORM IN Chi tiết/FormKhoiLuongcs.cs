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
    public partial class FormKhoiLuongcs : Form
    {
        private int index = -1;
        public FormKhoiLuongcs()
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
                DTOKhoiLuong kl = new DTOKhoiLuong(int.Parse(txtMaKhoiLuong.Text));

                if (!BUSKhoiLuong.Add(kl))
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewKL.DataSource = BUSKhoiLuong.showAll();

                    LoadPage();
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {

                DataGridViewRow row = dataGridViewKL.Rows[index];
                int ID = int.Parse(row.Cells[0].Value.ToString());

                // Xóa
                if (!BUSKhoiLuong.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {

                    MessageBox.Show("Xóa thành công");
                    dataGridViewKL.DataSource = BUSKhoiLuong.showAll(); // refresh datagridview

                    LoadPage();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn mục bạn muốn xóa");
            }
        }

        private void FormKhoiLuongcs_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridViewKL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKL.DataSource = BUSKhoiLuong.showAll();
        }

        private void LoadPage()
        {
            txtMaKhoiLuong.Text = "";
        }

        private void dataGridViewKL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = dataGridViewKL.Rows[index];
            txtMaKhoiLuong.Text = selectRow.Cells[0].Value.ToString();
            
        }

        private int checkData()
        {
            int t = 0;

            if (txtMaKhoiLuong.Text == "")
            {
                checkKL.Text = "X";
                checkKL.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkKL, "Bạn chưa nhập mã khối lượng!");
                t = 1;
            }
            else
            {
                checkKL.Text = "";
            }
            

            if (t == 1) return 1;
            else
            {
                return 0;
            }

        }
        private void loadLabelCheck()
        {
            checkKL.Text = "";
            

        }
    }
}

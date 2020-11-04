using DTO;
using BUS;
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
    public partial class FormLoaiGa : Form
    {
        private int index = -1;
        public FormLoaiGa()
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
                DTOLoaiGa lg = new DTOLoaiGa(txtMaLoai.Text, txtTenLoai.Text);

                if (!BUSLoaiGa.Add(lg))
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridViewLG.DataSource = BUSLoaiGa.showAll();

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
                if (!dataGridViewLG.Rows[index].Cells[0].Value.ToString().Equals(txtMaLoai.Text))
                {
                    txtMaLoai.Text = dataGridViewLG.Rows[index].Cells[0].Value.ToString();
                    MessageBox.Show("Bạn không được sửa mã loại ga!");
                }
                else
                {
                    if (checkData() == 1)
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đã sửa sai!");
                    }
                    else
                    {
                        DTOLoaiGa lg = new DTOLoaiGa(txtMaLoai.Text, txtTenLoai.Text);

                        if (!BUSLoaiGa.Edit(lg))
                        {
                            MessageBox.Show("Sửa không thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thành công");
                            dataGridViewLG.DataSource = BUSLoaiGa.showAll();

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

                DataGridViewRow row = dataGridViewLG.Rows[index];
                string ID = row.Cells[0].Value.ToString();

                // Xóa
                if (!BUSLoaiGa.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {

                    MessageBox.Show("Xóa thành công");
                    dataGridViewLG.DataSource = BUSLoaiGa.showAll(); // refresh datagridview

                    LoadPage();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn mục bạn muốn xóa");
            }
        }

        private void FormLoaiGa_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridViewLG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLG.DataSource = BUSLoaiGa.showAll();
        }

        private void dataGridViewLG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;//lấy vị trí hàng được click
            DataGridViewRow selectRow = dataGridViewLG.Rows[index];
            txtMaLoai.Text = selectRow.Cells[0].Value.ToString();
            txtTenLoai.Text = selectRow.Cells[1].Value.ToString();
        }
        private void LoadPage()
        {
            txtTenLoai.Text = "";
            txtMaLoai.Text = "";

        }
        private int checkData()
        {
            int t = 0;

            if (txtMaLoai.Text == "")
            {
                checkMaLoai.Text = "X";
                checkMaLoai.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMaLoai, "Bạn chưa nhập loại ga!");
                t = 1;
            }
            else
            {
                checkMaLoai.Text = "";
            }
            if (txtTenLoai.Text == "")
            {
                checkTenLoai.Text = "X";
                checkTenLoai.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkTenLoai, "Bạn chưa nhập tên loại ga!");
                t = 1;
            }
            else
            {
                checkTenLoai.Text = "";
            }

            if (t == 1) return 1;
            else
            {
                return 0;
            }

        }
        private void loadLabelCheck()
        {
            checkMaLoai.Text = "";
            checkTenLoai.Text = "";

        }
    }
}

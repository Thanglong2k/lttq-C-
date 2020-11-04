using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORMS.FORM_MENU
{
    public partial class FormQLTK : Form
    {
        public static int index = -1;
        public FormQLTK()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQLTK_Load(object sender, EventArgs e)
        {
            loadLabelCheck();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = BUSTaiKhoan.showAll();
            for (int i = 0; i <= 1; i++)
            {
                cbTT.Items.Add(i);
            }
            cbQuyen.Items.Add("admin");
            cbQuyen.Items.Add("user");
            lbTenND.Text = FormLogin.DTO.TenNguoiDung;
            lbTK.Text = FormLogin.DTO.TaiKhoan;
            lbEmail.Text = FormLogin.DTO.Email;
            lbMK.Text = FormLogin.DTO.MatKhau;
            lbQuyen.Text = FormLogin.DTO.Quyen;
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (checkData() == 1)
            {
                MessageBox.Show("Bạn chưa nhập đúng dữ liệu");
            }
            else
            {
                DTOTaiKhoan tk = new DTOTaiKhoan(txtND.Text, txtTK.Text, txtMK.Text, int.Parse(cbTT.Text), cbQuyen.Text, txtEmail.Text);
                if (!BUSTaiKhoan.Add(tk))
                {
                    MessageBox.Show("Thêm ko thành công");
                }
                else
                {

                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = BUSTaiKhoan.showAll();
                    LoadPage();
                }
            }
        }
        private void LoadPage()
        {
            txtTK.Text = "";
            txtMK.Text = "";
            cbQuyen.SelectedIndex = -1;
            cbTT.SelectedValue = 1;
            txtND.Text = "";
            txtEmail.Text = "";
            
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Hãy chọn đối tượng bạn muốn sửa!");
            }
            else
            {
                if (!dataGridView1.Rows[index].Cells[0].Value.ToString().Equals(txtTK.Text))
                {
                    MessageBox.Show("Bạn không được sửa tài khoản!");
                }
                else
                {
                    if (checkData() == 1)
                    {
                        MessageBox.Show("Kiểm tra lại thông tin đã sửa sai!");
                    }
                    else
                    {
                        DTOTaiKhoan tk = new DTOTaiKhoan(txtND.Text, txtTK.Text, txtMK.Text, int.Parse(cbTT.Text), cbQuyen.Text, txtEmail.Text);
                        if (!BUSTaiKhoan.Edit(tk))
                        {
                            MessageBox.Show("Sửa ko thành công");
                        }
                        else
                        {

                            MessageBox.Show("Sửa thành công");
                            dataGridView1.DataSource = BUSTaiKhoan.showAll();
                            LoadPage();
                        }
                    }
                }
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dataGridView1.Rows[index];
                string ID = row.Cells[1].Value.ToString();

                // Xóa
                if (!BUSTaiKhoan.Delete(ID))
                {
                    MessageBox.Show("Xóa ko thành công");
                }
                else
                {

                    MessageBox.Show("Xóa thành công");
                    dataGridView1.DataSource = BUSTaiKhoan.showAll(); // refresh datagridview

                    LoadPage();
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn mục bạn muốn xóa");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;//lấy vị trí hàng được click
                DataGridViewRow selectRow = dataGridView1.Rows[index];
                txtND.Text = selectRow.Cells[4].Value.ToString();
                txtTK.Text = selectRow.Cells[0].Value.ToString();                           
                txtMK.Text = selectRow.Cells[1].Value.ToString();
                cbQuyen.Text = selectRow.Cells[3].Value.ToString();
                txtEmail.Text = selectRow.Cells[5].Value.ToString();
                cbTT.Text = selectRow.Cells[2].Value.ToString();
            }
            catch
            {
            }
        }
        private int checkData()
        {
            int t = 0;
            if (txtND.Text == "")
            {
                checkND.Text = "X";
                checkND.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkND, "Bạn chưa nhập tên người dùng!");
                t = 1;
            }
            else
            {
                checkND.Text = "";
            }
            if (txtTK.Text == "")
            {
                checkTK.Text = "X";
                checkTK.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkTK, "Bạn chưa nhập tài khoản!");
                t = 1;
            }
            else
            {
                checkTK.Text = "";
            }
            if (txtMK.Text == "")
            {
                checkMK.Text = "X";
                checkMK.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkMK, "Bạn chưa nhập mật khẩu!");
                t = 1;
            }
            else
            {
                checkMK.Text = "";

            }

            if (txtEmail.Text == "")
            {
                checkEmail.Text = "X";
                checkEmail.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkEmail, "Bạn chưa nhập email!");
                t = 1;
            }
            else
            {
                if (IsValid(txtEmail.Text) == false)
                {
                    checkEmail.Text = "X";
                    checkEmail.ForeColor = Color.Red;
                    toolTip1.SetToolTip(checkEmail, "Bạn nhập sai định dạng email!");
                    t = 1;
                }
                else
                {
                    checkEmail.Text = "";
                }
            }
            if (cbQuyen.SelectedIndex == -1)
            {
                checkQuyen.Text = "X";
                checkQuyen.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkQuyen, "Bạn chưa chọn quyền!");
                t = 1;
            }
            else
            {
                checkQuyen.Text = "";

            }
            if (cbTT.SelectedIndex == -1)
            {
                checkTT.Text = "X";
                checkTT.ForeColor = Color.Red;
                toolTip1.SetToolTip(checkTT, "Bạn chưa chọn trạng thái hoạt động!");
                t = 1;
            }
            else
            {
                checkTT.Text = "";

            }
            if (t == 1) return 1;
            else
            {
                return 0;
            }

        }
        private void loadLabelCheck()
        {
            checkEmail.Text = "";
            checkMK.Text = "";
            checkND.Text = "";
            checkTK.Text = "";
            checkTT.Text = "";
            checkQuyen.Text = "";
        }
        private bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}

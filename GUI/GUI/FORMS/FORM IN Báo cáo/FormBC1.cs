using BUS;
using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.FORMS.FORM_IN_BC
{
    public partial class FormBC1 : Form
    {
        public FormBC1()
        {
            InitializeComponent();
        }

        private void FormBC1_Load(object sender, EventArgs e)
        {
           // this.reportViewer1.RefreshReport();
            FillCbo("NhanVien", cbNV, "MaNV", "TenNV");
        }
        public void FillCbo(string nameTB, ComboBox cbo, string ma, string ten)
        {


            string newC = "NameAndCode";
            DataTable t = BUSNhanVien.showAll(nameTB);
            AddMultipleColumn(t, newC, ma, ten);

            
            cbo.DataSource = t;
            cbo.ValueMember = ma;//giá trị lấy xuống
            cbo.DisplayMember = newC;
            cbo.SelectedIndex = -1;
        }
        public void AddMultipleColumn(DataTable t, string nameOfNewColumn, string column1, string column2)
        {
            string expression = column1 + " + '-' + " + column2;
            t.Columns.Add(nameOfNewColumn, typeof(string), expression);
        }

        private void btnHIenThi_Click(object sender, EventArgs e)
        {
            string ten = cbNV.Text;
            int sub = cbNV.Text.LastIndexOf("-");
            string tenNV = ten.Substring(sub + 1);
            DataSet ds = BUSNhanVien.NVBanItNhat(cbNV.SelectedValue.ToString());
            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("MaNV",tenNV);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\trant\\OneDrive\\Máy tính\\BTL\\GUI\\GUI\\FORMS\\FORM IN Báo cáo\\Report1.rdlc";
            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "SP_NV";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}

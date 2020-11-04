using BUS;
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
    public partial class FormBC3 : Form
    {
        public FormBC3()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbThang.Text);
            int nam = int.Parse(cbNam.Text);
         
            DataSet ds = BUSReport.DoanhThu_Thang( thang, nam);
            ReportParameter[] param = new ReportParameter[2];         
            param[0] = new ReportParameter("Thang", thang.ToString());
            param[1] = new ReportParameter("Nam", nam.ToString());
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\trant\\OneDrive\\Máy tính\\BTL\\GUI\\GUI\\FORMS\\FORM IN Báo cáo\\Report3.rdlc";
            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DoanhThu_Thang";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
        public void FillCbo(DataTable nameTB, ComboBox cbo, string ma, string ten)
        {

            cbo.DataSource = nameTB;
            cbo.ValueMember = ma;//giá trị lấy xuống
            cbo.DisplayMember = ten;
            cbo.SelectedIndex = -1;
        }
        private void thang()
        {
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
        }

        private void FormBC3_Load(object sender, EventArgs e)
        {

            FillCbo(BUSReport.selectAllNam("HoaDonBan","NgayBan"), cbNam, "Nam", "Nam");
            thang();
            this.reportViewer1.RefreshReport();
        }
    }
}

﻿using BUS;
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
    public partial class FormBC2 : Form
    {
        public FormBC2()
        {
            InitializeComponent();
        }

        private void FormBC2_Load(object sender, EventArgs e)
        {
            FillCbo(BUSNhaCungCap.showAll(), cbNCC, "MaNCC", "TenNCC");
            FillCbo(BUSReport.selectAllNam("HOaDonNhap","NgayNhap"), cbNam, "Nam", "Nam");
            thang();
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
        

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string ten = cbNCC.Text;
            int thang = int.Parse(cbThang.Text);
            int nam = int.Parse(cbNam.Text);
            int sub = cbNCC.Text.LastIndexOf("-");
            string tenNV = ten.Substring(sub + 1);
            DataSet ds = BUSReport.HD_TTN_NCC(cbNCC.SelectedValue.ToString(),thang,nam);
            ReportParameter[] param = new ReportParameter[3];
            param[0] = new ReportParameter("MaNCC", tenNV);
            param[1] = new ReportParameter("Thang", thang.ToString());
            param[2] = new ReportParameter("Nam", nam.ToString());
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\trant\\OneDrive\\Máy tính\\BTL\\GUI\\GUI\\FORMS\\FORM IN Báo cáo\\Report2.rdlc";
            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "HD_TTN_NCC";
                rds.Value = ds.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}

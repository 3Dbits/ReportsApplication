using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1
  = new Microsoft.Reporting.WinForms.ReportDataSource();
            AdventureWorks2019DataSet dataset = new AdventureWorks2019DataSet();
            AdventureWorks2019DataSetTableAdapters.ProductTableAdapter data_ad
             = new AdventureWorks2019DataSetTableAdapters.ProductTableAdapter();
            AdventureWorks2019DataSet.ProductDataTable edt
             = new AdventureWorks2019DataSet.ProductDataTable();
            data_ad.Fill(edt);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = edt;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportPath = @"../../Report1.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
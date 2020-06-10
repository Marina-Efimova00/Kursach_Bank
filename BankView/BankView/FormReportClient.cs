using BankBussinessLogic.BusinessLogics;
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
using Unity;

namespace BankView
{
    public partial class FormReportClient : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReportLogic logic;
        public FormReportClient(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormReportClient_Load(object sender, EventArgs e)
        {
            try
            {
                var dataSource = logic.GetClients();
                ReportDataSource source = new ReportDataSource("DataSetClient", dataSource);
               // reportViewer.LocalReport.DataSources.Add(source);
               // reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}

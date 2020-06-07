using BankBussinessLogic.BusinessLogics;
using BankBussinessLogic.Interfaces;
using BankBussinessLogic.ViewModel;
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
    public partial class FormReportService : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReportLogic logic;
        public FormReportService(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormReportService_Load(object sender, EventArgs e)
        {
            try
            {
                var ser = logic.GetServices();
                if (ser != null)
                {

                    dataGridView.Rows.Clear();
                    
                    foreach (var date in ser)
                    {
                        dataGridView.Rows.Add(new object[] { "", date.WorkerFIO, date.TypeService });
                    }
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSend>();
            form.ShowDialog();
        }
    }
}

using BankBussinessLogic.BindingModel;
using BankBussinessLogic.Interfaces;
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
    public partial class FormService : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IServiceLogic serviceLogic;
        public FormService(IServiceLogic serviceLogic)
        {
            InitializeComponent();
            this.serviceLogic = serviceLogic;
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = serviceLogic.Read(null);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = false;
                   // dataGridView.Columns[2].Visible = false;
                    // dataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}

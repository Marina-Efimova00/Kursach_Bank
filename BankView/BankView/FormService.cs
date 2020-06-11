using BankBussinessLogic.BindingModel;
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
    public partial class FormService : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IClientLogic clientLogic;
        public int Id { set { id = value; } }
        private int? id;
        private Dictionary<int, (string, int)> ServiceClients;
        public FormService(IClientLogic clientLogic)
        {
            InitializeComponent();
            this.clientLogic = clientLogic;
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ClientViewModel view = clientLogic.Read(new ClientBindingModel
                    {
                        Id = id.Value
                    })?[0];
                    if (view != null)
                    {
                        ServiceClients = view.ServiceClients;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                ServiceClients = new Dictionary<int, (string, int)>();
            }
        }
        private void LoadData()
        {
            try
            {
                if (ServiceClients != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var bf in ServiceClients)
                    {
                        dataGridView.Rows.Add(new object[] { bf.Key, bf.Value.Item1, bf.Value.Item2 });

                    }
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

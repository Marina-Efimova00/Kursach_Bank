using BankBussinessLogic.BindingModel;
using BankBussinessLogic.BusinessLogics;
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
    public partial class FormCreate : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IClientLogic logicC;
        private readonly IWorkerLogic logicW;
        private readonly IServiceLogic logicS;
        private readonly ServiceLogic logic;
        public FormCreate(IWorkerLogic logicW, IServiceLogic logicS, IClientLogic logicC, ServiceLogic logic)
        {
            InitializeComponent();
            this.logicW = logicW;
            this.logicS = logicS;
            this.logicC = logicC;
            this.logic = logic;
        }

        private void FormCreate_Load(object sender, EventArgs e)
        {
            try
            {
                var list = logicW.Read(null);
                comboBoxWorkerFIO.DataSource = list;
                comboBoxWorkerFIO.DisplayMember = "WorkerFIO";
                comboBoxWorkerFIO.ValueMember = "Id";
                var listC = logicC.Read(null);
                comboBoxClientFIO.DisplayMember = "ClientFIO";
                comboBoxClientFIO.ValueMember = "Id";
                comboBoxClientFIO.DataSource = listC;
                comboBoxClientFIO.SelectedItem = null;
                var listS = logicS.Read(null);
                comboBoxService.DataSource = list;
                comboBoxService.DisplayMember = "TypeService";
                comboBoxService.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
          
            if (comboBoxWorkerFIO.SelectedValue == null)
            {
                MessageBox.Show("Заполните поле ФИО сотрудника", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxService.SelectedValue == null)
            {
                MessageBox.Show("Заполните поле Услуга", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (comboBoxClientFIO.SelectedValue == null)
            {
                MessageBox.Show("Заполните поле ФИО клиента", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.Create(new CreateBindingModel
                {
                    WorkerId = Convert.ToInt32(comboBoxWorkerFIO.SelectedValue),
                    ClientId = Convert.ToInt32(comboBoxClientFIO.SelectedValue),
                    TypeService = comboBoxService.Text
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

using BankBussinessLogic.BindingModel;
using BankBussinessLogic.Enums;
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
    public partial class FormSalary : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IWorkerLogic logicW;
        private readonly IServiceLogic logicS;
        public FormSalary(IWorkerLogic logicW, IServiceLogic logicS)
        {
            InitializeComponent();
            this.logicW = logicW;
            this.logicS = logicS;
        }

        private void FormSalary_Load(object sender, EventArgs e)
        {
            try
            {
                var list = logicW.Read(null);
                comboBoxFIO.SelectedItem = null;
                comboBoxFIO.DataSource = list;
                comboBoxFIO.DisplayMember = "WorkerFIO";
                comboBoxFIO.ValueMember = "Id";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void CalcSum()
        {
            
            if (comboBoxFIO.SelectedItem != null && !string.IsNullOrEmpty(textBoxSalary.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxFIO.SelectedValue);
                    WorkerBindingModel model = new WorkerBindingModel();
                    int countDone = 0;
                    int countClient = 0;
                    var service = logicS.Read(new ServiceBindingModel{WorkerId = id})?[0];
                    var servi = logicS.Read(null);
                    foreach (var serv in servi)
                    {
                        if (service.Status == Status.Готово)
                        countDone++;
                        if ((service.Status == Status.Готово) || (service.Status == Status.Выполняется))
                        countClient++;
                    }
                    if (countDone == countClient)
                        model.Salary = 40000;
                    if (countDone < countClient)
                        model.Salary = 30000;
                    textBoxSalary.Text = model.Salary.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void comboBoxFIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSalary.Text))
            {
                MessageBox.Show("Заполните поле Зарплата", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxFIO.SelectedValue == null)
            {
                MessageBox.Show("Выберите ФИО сотрудника", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                logicW.CreateOrUpdate(new WorkerBindingModel
                {
                    Id = Convert.ToInt32(comboBoxFIO.SelectedValue),
                    Salary =Convert.ToInt32(textBoxSalary.Text)
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

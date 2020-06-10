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
    public partial class FormClient : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly IClientLogic logic;
        private int? id;
        public FormClient(IClientLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new ClientBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxFIO.Text = view.ClientFIO;
                        textBoxGender.Text = view.Gender;
                        textBoxJob.Text = view.Job;
                        textBoxPassportData.Text = view.PassportData.ToString();
                        textBoxNumber.Text = view.Number.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxGender.Text))
            {
                MessageBox.Show("Заполните пол", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxJob.Text))
            {
                MessageBox.Show("Заполните работу", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassportData.Text))
            {
                MessageBox.Show("Заполните паспортные данные", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Заполните номер телефона", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                Random rnd = new Random();
                var list = new List<ServiceClientBindingModel>();
                int count = Convert.ToInt32(textBoxCount.Text);
                for(int i = 0; i < count; i++)
                {
                    list.Add(new ServiceClientBindingModel { ClientId = id, ServiceId = rnd.Next(1, 10) });
                }
                logic.CreateOrUpdate(new ClientBindingModel
                {
                    Id = id,
                    ClientFIO = textBoxFIO.Text,
                    Gender = textBoxGender.Text,
                    Job = textBoxJob.Text,
                    PassportData = Convert.ToInt32(textBoxPassportData.Text),
                    Number = Convert.ToInt32(textBoxNumber.Text),
                    CountService = Convert.ToInt32(textBoxCount.Text),
                    ServiceClients = list
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

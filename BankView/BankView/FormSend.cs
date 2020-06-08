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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankView
{
    public partial class FormSend : Form
    {
        public readonly IServiceLogic logic;
        public readonly IWorkerLogic logicW;
        public readonly ReportLogic reportLogic;
        public FormSend(IServiceLogic logic, ReportLogic reportLogic, IWorkerLogic logicW)
        {
            InitializeComponent();
            this.logic = logic;
            this.reportLogic = reportLogic;
            this.logicW = logicW;
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMail.Text))
            {
                MessageBox.Show("Заполните Email", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!checkBoxDoc.Checked && !checkBoxXls.Checked)
            {
                MessageBox.Show("Выберите формат документа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var service = logic.Read(null);
                if (checkBoxDoc.Checked)
                {
                    foreach (var elem in service)
                    {
                        string fileName = "C:\\Users\\marin.LAPTOP-0TUFHPTU\\Рабочий стол\\универ\\data\\" + "Отчет по выплненным услугам.docx";
                        reportLogic.SaveServicesToWordFile(fileName, elem, textBoxMail.ToString());
                    }
                }
                if (checkBoxXls.Checked)
                {
                    foreach (var elem in service)
                    {
                        string fileName = "C:\\Users\\marin.LAPTOP-0TUFHPTU\\Рабочий стол\\универ\\data\\" + "Worker.xls";
                        reportLogic.SaveServicesToExcelFile(fileName, elem, textBoxMail.ToString());
                    }
                }

                    MessageBox.Show("Отправлено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSend_Load(object sender, EventArgs e)
        {
            try
            {
                
                var list = logicW.Read(null);
                comboBoxFIO.DataSource = list;
                comboBoxFIO.DisplayMember = "WorkerFIO";
                comboBoxFIO.ValueMember = "Email";
                comboBoxFIO.SelectedItem = null;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void comboBoxFIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFIO.SelectedValue != null)
             textBoxMail.Text = comboBoxFIO.SelectedValue.ToString();
        }
    }
}


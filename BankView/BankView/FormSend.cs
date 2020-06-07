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
        public readonly ReportLogic reportLogic;
        public FormSend(IServiceLogic logic, ReportLogic reportLogic)
        {
            InitializeComponent();
            this.logic = logic;
            this.reportLogic = reportLogic;
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
                foreach (var elem in service)
                {
                    string fileName = "С://data//" + "Worker.docx";
                    reportLogic.SaveServicesToWordFile(fileName, elem, textBoxMail.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}


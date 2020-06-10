using BankBussinessLogic.BusinessLogics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace BankView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly BackUpAbstractLogic backUpAbstractLogic;
        public FormMain(BackUpAbstractLogic backUpAbstractLogic)
        {
            InitializeComponent();
            this.backUpAbstractLogic = backUpAbstractLogic;
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClients>();
            form.ShowDialog();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form = Container.Resolve<FormService>();
            form.ShowDialog();
        }

        private void расчтеССотрудникамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormWorker>();
            form.ShowDialog();
        }

        private void отчетПоВыполненнымУслугамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReportService>();
            form.ShowDialog();
        }

        private void отчетПоКлиентамИИхСчетуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReportClient>();
            form.ShowDialog();
        }

        private void создатьБекапToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\Users\\marin.LAPTOP-0TUFHPTU\\Рабочий стол\\универ\\бэкап\\бекап";
            if (Directory.Exists(fileName))
            {
                backUpAbstractLogic.CreateArchive(fileName);
                //return RedirectToAction("BackUp");
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(fileName);
                backUpAbstractLogic.CreateArchive(fileName);
                //return RedirectToAction("BackUp");
            }
        }
    }
}

using BankBussinessLogic.BindingModel;
using BankBussinessLogic.Enums;
using BankBussinessLogic.HelperInfo;
using BankBussinessLogic.Interfaces;
using BankBussinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace BankBussinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly IServiceLogic serviceLogic;
        private readonly IWorkerLogic workerLogic;
        public ReportLogic(IServiceLogic serviceLogic, IWorkerLogic workerLogic)
        {
            this.serviceLogic = serviceLogic;
            this.workerLogic = workerLogic;
        }
        public List<ServiceViewModel> GetServices()
        {
            var services = serviceLogic.Read(null);
            var list = new List<ServiceViewModel>();
            foreach (var serv in services)
            {
                if (serv.Status == Status.Готово)
                {
                    var record = new ServiceViewModel
                    {
                        WorkerFIO = serv.WorkerFIO,
                        TypeService = serv.TypeService,
                        Status = serv.Status
                    };
                    list.Add(record);
                }
            }
            return list;
        }
        public void SaveServicesToExcelFile(string fileName, ServiceViewModel service, string email)
        {
            string title = "Выполненые услуги";
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = fileName,
                Title = title,
                Services = GetServices(),
            }) ;
            SendMail(email, fileName, title);
        }
        public void SaveServicesToWordFile(string fileName, ServiceViewModel service, string email)
        {
            string title = "Выполненые услуги" ;
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = fileName,
                Title = title,
                Services = GetServices(),
            });
           // SendMail(email, fileName, title);
        }
        public void SendMail(string email, string fileName, string subject)
        {
            MailAddress from = new MailAddress("efimova.marina0029@gmail.com", "Туристическая фирма «Иван Сусанин»");
            MailAddress to = new MailAddress(email);
            MailMessage m = new MailMessage(from, to);
            m.Subject = subject;
            m.Attachments.Add(new Attachment(fileName));
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("efimova.marina0029@gmail.com", "iravol73");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}

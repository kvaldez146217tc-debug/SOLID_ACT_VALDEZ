using SOLID_ACT_VALDEZ.Models;
using SOLID_ACT_VALDEZ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Services
{
    public class SmtpInvoiceSender : IInvoiceSender
    {
        private readonly string smtpHost;
        private readonly string fromAddress;

        public SmtpInvoiceSender(string smtpHost, string fromAddress)
        {
            this.smtpHost = smtpHost;
            this.fromAddress = fromAddress;
        }

        public void SendInvoice(Order order)
        {
            using (var smtp = new SmtpClient(smtpHost))
            using (var mail = new MailMessage(fromAddress, order.CustomerEmail))
            {
                mail.Body = $"Your total is {order.Total:C}";
                smtp.Send(mail);
            }
        }
    }
}

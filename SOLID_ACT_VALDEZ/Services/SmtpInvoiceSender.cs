using SOLID_ACT_VALDEZ.Models;
using SOLID_ACT_VALDEZ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ACT_VALDEZ.Services
{
    public class SmtpInvoiceSender : IInvoiceSender
    {
        private readonly string smtpHost;
        private readonly int smtpPort;
        private readonly string fromAddress;
        private readonly string username;
        private readonly string password;

        public SmtpInvoiceSender(string smtpHost, int smtpPort, string fromAddress, string username, string password)
        {
            this.smtpHost = smtpHost;
            this.smtpPort = smtpPort;
            this.fromAddress = fromAddress;
            this.username = username;
            this.password = password;
            
        }


        public void SendInvoice(Order order)
        {
            using (var smtp = new SmtpClient(smtpHost, smtpPort))
            using (var mail = new MailMessage(fromAddress, order.CustomerEmail))
            {
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(username, password);

                mail.Subject = "Your Invoice";
                mail.Body = $"Your total is {order.Total:C}";
                smtp.Send(mail);
            }
        }
    }
}

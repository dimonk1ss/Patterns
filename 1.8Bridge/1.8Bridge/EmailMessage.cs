using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETCore.MailKit;
using _1._8Bridge.Email;
namespace _1._8Bridge
{
    public class EmailMessage : Mesage
    {
        public void Send()
        {
            Message message = new Message();
            message.Body = "Привіт козак!";
            message.Subject = "Мені уже 18 :)";
            message.To = "dkhprb@gmail.com";

            IEmailService emailService = new SmtpEmailService();
            emailService.Send(message);
        }
    }
}

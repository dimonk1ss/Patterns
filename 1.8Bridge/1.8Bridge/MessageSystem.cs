using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8Bridge
{
    public class MessageSystem
    {
        private Mesage email;
        private Mesage sms;
        

        public MessageSystem()
        {
            email = new EmailMessage();
            sms = new SMS();
        }

        public void SendEmailMessage()
        {
            email.Send();
        }
        public void SendSMS()
        {
            sms.Send();
        }

    }
}

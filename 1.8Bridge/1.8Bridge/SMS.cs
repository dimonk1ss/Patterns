using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _1._8Bridge
{
    public  class SMS : Mesage
    {
        public void Send()
        {
            SMSService service = new SMSService();
            service.Send("+380969132110","123");
        }
    }
}

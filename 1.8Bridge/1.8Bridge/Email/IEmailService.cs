using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8Bridge.Email
{
    public interface IEmailService
    {
        void Send(Message message);
    }
}

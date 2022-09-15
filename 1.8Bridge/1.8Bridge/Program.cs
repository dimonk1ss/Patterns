using System;
namespace _1._8Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSystem messageSystem = new MessageSystem();
            messageSystem.SendEmailMessage();
            messageSystem.SendSMS();
        }
    }
}

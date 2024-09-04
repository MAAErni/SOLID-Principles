using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string emailContent)
        {
            Console.WriteLine("Sent Email: "+ emailContent);
        }
    }
}



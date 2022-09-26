using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._7___Structural_Pattern_Decorator {
    public class CloudMailService : IMailService {
        public bool SendMail(string message) {
            Console.WriteLine($"Message \" {message} \" sent via {nameof(CloudMailService)}.");
            return true;                 
        }
    }
}

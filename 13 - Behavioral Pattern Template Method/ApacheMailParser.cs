using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method {
    public class ApacheMailParser : MailParser {
        public override void AuthenticateToServer() {
            Console.WriteLine("Connecting to Appache");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_Method;

namespace Template_Method {
    public class ExchangeMailParser : MailParser {
        public override void AuthenticateToServer() {
            Console.WriteLine("Connecting to Exchange");
        }
    }
}

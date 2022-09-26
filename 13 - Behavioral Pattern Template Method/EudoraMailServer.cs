using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_Method;

namespace Template_Method {
    public class EudoraMailServer : MailParser {
        public override void FindServer() {
            Console.WriteLine("Find Eudora server through a custom algoritm");
        }
        public override void AuthenticateToServer() {
            Console.WriteLine("Connection to Eudora");
        }
    }
}

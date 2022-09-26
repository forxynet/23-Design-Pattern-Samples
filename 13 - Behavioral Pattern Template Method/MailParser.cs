using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method {
    public abstract class MailParser {
        public virtual void FindServer() {
            Console.WriteLine("Finding server...");
        }
        public abstract void AuthenticateToServer();
        public string ParseHtmlMailBody(string identifier) {
            Console.WriteLine("Parsing HTML mail body...");
            return $"This is the body of mail wit id {identifier}";
        }
        public string ParseMailBody(string identifier) {
            Console.WriteLine("Parsing mail body (in template method)...");
            FindServer();
            AuthenticateToServer();
            return ParseHtmlMailBody(identifier);
        }
    }
}

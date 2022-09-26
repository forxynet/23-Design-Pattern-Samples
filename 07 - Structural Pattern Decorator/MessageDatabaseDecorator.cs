using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._7___Structural_Pattern_Decorator {
    public class MessageDatabaseDecorator : MailServiceDecoratorBase {
        /// <summary>
        /// A list of sent message - a "fake" database 
        /// </summary>
        public List<string> SentMessages { get; private set; } = new List<string>();
        public MessageDatabaseDecorator(IMailService mailService) : base(mailService) {
        }

        public override bool SendMail(string message) {


            if (base.SendMail(message)) {
                // store send message
                SentMessages.Add(message);
                return true;
            }
            return false;
        }
    }
}

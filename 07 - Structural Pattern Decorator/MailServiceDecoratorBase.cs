using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._7___Structural_Pattern_Decorator {
    public abstract class MailServiceDecoratorBase : IMailService {
        private readonly IMailService _mailService;

        public MailServiceDecoratorBase(IMailService mailService) {
            _mailService = mailService;
        }
        public virtual bool SendMail(string message) {
            return _mailService.SendMail(message);
        }
    }
}

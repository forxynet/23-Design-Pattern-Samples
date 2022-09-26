using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._7___Structural_Pattern_Decorator {
    public class StatisticDecorator : MailServiceDecoratorBase {
        public StatisticDecorator(IMailService mailService) : base(mailService) {

        }
        public override bool SendMail(string message) {

            // Fake collecting statistics
            Console.WriteLine($"Collecting statistic in {nameof(StatisticDecorator)}");
            return base.SendMail(message);
        }
    }
}

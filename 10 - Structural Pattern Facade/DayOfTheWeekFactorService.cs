using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._10___Structural_Pattern_Facade {
    public class DayOfTheWeekFactorService {
        public double CalculateDayOfWeekFactor() {
            // fake calculation for demo purpose
            switch (DateTime.UtcNow.DayOfWeek) {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return 0.8;
                default:
                    return 1.2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._10___Structural_Pattern_Facade {
    public class CustomerDiscountBaseService {
        public double CalculateDiscountBase(int customerId) {
            // fake calculation for demo purpose
            return (customerId > 8) ? 10 : 20;
        }
    }
}

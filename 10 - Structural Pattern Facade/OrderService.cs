using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._10___Structural_Pattern_Facade {
    public class OrderService {
        public bool HasEnoughOrders(int customerId) {
            // does the customer have enough orders?
            // fake calculation for demo purpose
            return (customerId > 5);
        }
    }
}

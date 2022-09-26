using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._10___Structural_Pattern_Facade {
    public class DiscountFacate {
        private readonly OrderService _orderService = new();
        private readonly CustomerDiscountBaseService _customerDiscountBaseService = new();
        private readonly DayOfTheWeekFactorService _dayOfTheWeekFactorService = new();
   
        public double CalculateDiscountPercentage(int customerId) {
            if (!_orderService.HasEnoughOrders(customerId)) 
                return 0;
           
            return _customerDiscountBaseService.CalculateDiscountBase(customerId)
                * _dayOfTheWeekFactorService.CalculateDayOfWeekFactor();
        }
    }
}

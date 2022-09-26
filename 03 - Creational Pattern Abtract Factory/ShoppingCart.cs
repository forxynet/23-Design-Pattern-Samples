using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._3___Abtract_Factory {
    public class ShoppingCart {
        private readonly IDiscountService _discountService;
        private readonly IShippingConstsService _shippingConstsService;
        private int _orderCosts;
        public ShoppingCart(IShoppingCartPurchaseFactory factory) {
            _discountService = factory.CreateDiscountService();
            _shippingConstsService = factory.CreateShippingCostsService();
            // assume that the total cost of all the items we ordered = 200 euro
            _orderCosts = 200;
        }
        public void CanculateCosts() {
            Console.WriteLine($"Total costs = {_orderCosts - (_orderCosts /100 * _discountService.DiscountPercentage ) + _shippingConstsService.ShippingCosts}");
        }
    }
}

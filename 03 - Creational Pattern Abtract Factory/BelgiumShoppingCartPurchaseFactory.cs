using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._3___Abtract_Factory {
    public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory {
        public IDiscountService CreateDiscountService() {
            return new BelgiumDiscountService();
        }

        public IShippingConstsService CreateShippingCostsService() {
            return new BelgiumShippingCostsService();
        }
    }
}

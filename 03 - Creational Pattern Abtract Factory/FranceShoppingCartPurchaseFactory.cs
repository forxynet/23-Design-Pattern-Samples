using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._3___Abtract_Factory {
    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory {
        public IDiscountService CreateDiscountService() {
            return new FranceDiscountService();
        }

        public IShippingConstsService CreateShippingCostsService() {
            return new FranceShippingCostsService();
        }
    }
}

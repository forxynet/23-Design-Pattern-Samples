using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._8___Bridge {
    public class VegataarianMenu : Menu {
        public VegataarianMenu(ICoupon coupon) : base(coupon) {
        }

        public override int CalculatePrice() {
            return 20 - _coupon.CouponValue;
        }
    }
}

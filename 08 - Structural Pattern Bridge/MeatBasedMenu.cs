using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._8___Bridge {
    public class MeatBasedMenu : Menu {
        public MeatBasedMenu(ICoupon coupon) : base(coupon) {
        }

        public override int CalculatePrice() {
            return 30 - _coupon.CouponValue;
        }
    }
}

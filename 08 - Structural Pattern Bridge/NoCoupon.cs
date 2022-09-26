using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._8___Bridge {
    public class NoCoupon : ICoupon{
        public int CouponValue => 0;
    }
}

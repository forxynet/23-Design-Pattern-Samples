using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler.Factory {
    public abstract class DiscountService {
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;
    }
}

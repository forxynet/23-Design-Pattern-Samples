﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._3___Abtract_Factory {
    public class FranceShippingCostsService : IShippingConstsService {
        public decimal ShippingCosts => 25;
    }
}

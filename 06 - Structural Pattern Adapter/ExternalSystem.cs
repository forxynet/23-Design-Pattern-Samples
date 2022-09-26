using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._6___Structural_Pattern_Adapter {
    public class ExternalSystem {
        public CityFromExternalSystemcs GetCity() {
            return new CityFromExternalSystemcs("Antwerp","' t Stad", 5000000);
        }
    }
}

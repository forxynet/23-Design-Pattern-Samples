using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._6___Structural_Pattern_Adapter {
    public class CityAdapter : ExternalSystem, ICityAdapter {
        public new City GetCity() {
            // call into the external system
            var cityFromExternalSystem = base.GetCity();

            // adapt the CityFromExternal to a City
            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}",
                cityFromExternalSystem.Inhabitatnts);
        }
    }
}

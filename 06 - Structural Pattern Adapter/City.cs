using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._6___Structural_Pattern_Adapter {
    public class City {
        public string FullName { get; private set; }
        public long Inhabitants { get; private set; }
        public City(string fullName, long ınhabitants) {
            FullName = fullName;
            Inhabitants = ınhabitants;
        }
    }
}

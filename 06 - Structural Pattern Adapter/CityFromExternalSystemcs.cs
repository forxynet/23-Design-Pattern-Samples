using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._6___Structural_Pattern_Adapter {
    public class CityFromExternalSystemcs {
        public string Name { get; private set; }
        public string NickName { get; private set; }
        public int Inhabitatnts { get; private set; }
        public CityFromExternalSystemcs(string name, string nickname, int inhabitants) {
            Name = name;
            NickName = nickname;
            Inhabitatnts = inhabitants;
        }

    }
}

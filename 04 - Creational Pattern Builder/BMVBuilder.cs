using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._4___Builder {
    public class BMVBuilder : CarBuilder {
        public BMVBuilder() : base("BMW") {
        }

        public override void BuildEngine() {
            Car.AddPart("'a fancy V8 engine'");
        }

        public override void BuildFrame() {
            Car.AddPart("'5-door with metallic finish'");
        }
    }
}

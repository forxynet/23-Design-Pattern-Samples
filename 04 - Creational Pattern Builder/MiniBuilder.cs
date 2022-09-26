using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._4___Builder {
    public class MiniBuilder : CarBuilder {
        public MiniBuilder() 
            : base("Mini") {
        }

        public override void BuildEngine() {
            Car.AddPart("'not a V8'");
        }

        public override void BuildFrame() {
            Car.AddPart("'3-door with stripes'");
        }
    }
}

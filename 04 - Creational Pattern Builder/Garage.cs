using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandler._4___Builder {
    public class Garage {
        private CarBuilder? _builder;
        public Garage() {

        }
        public void Construct(CarBuilder builder) {
            _builder = builder;
            _builder.BuildEngine();
            _builder.BuildFrame(); 
        }

        public void Show() {
            Console.WriteLine(_builder?.Car.ToString());
        }
    }
}

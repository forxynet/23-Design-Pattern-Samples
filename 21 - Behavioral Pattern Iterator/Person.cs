using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Iterator {
    public class Person {
        public string Name { get; init; }
        public string Country { get; init; }

        public Person(string name, string country) {
            Name = name;
            Country = country;
        }
    }
}

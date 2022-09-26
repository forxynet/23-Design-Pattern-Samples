using Org.BouncyCastle.Asn1.Nist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor {
    public class Employee : IElement {
        public int YearsEmployed { get; private set; }
        public decimal Discount { get; set; }
        public string Name { get; set; }

        public Employee(string name, int yearsEmployed) {
            Name = name;
            YearsEmployed = yearsEmployed;
        }

        public void Accept(IVisitor visitor) {
            //visitor.VisiEmployee(this);
            visitor.Visit(this);
            Console.WriteLine($"Visited {nameof(Employee)} {Name}, discount given: {Discount}");
        }
    }
}

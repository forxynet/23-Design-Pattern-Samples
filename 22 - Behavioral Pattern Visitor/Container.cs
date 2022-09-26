﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor {
    public class Container {
        public List<Employee> Employees { get; set; } = new();
        public List<Customer> Customers { get; set; } = new();

        public void Accept(IVisitor visitor) {
            foreach (var employee in Employees) {
                employee.Accept(visitor);
            }
            foreach (var customer in Customers) {
                customer.Accept(visitor);
            }
        }
    }
}

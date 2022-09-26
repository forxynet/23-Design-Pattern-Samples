using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento {
    public class AddEmployeeToManagerListMemonto {
        public int ManagerId { get; private set; }
        public Employee? Employee { get; private set; }
        public AddEmployeeToManagerListMemonto(int managerId, Employee? employee) {
            ManagerId = managerId;
            Employee = employee;
        }
    }
}

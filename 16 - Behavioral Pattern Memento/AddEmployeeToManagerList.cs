using Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento {
    public class AddEmployeeToManagerList : ICommand {
        private readonly IEmployeeManagerRepository _employeeManagerRepository;
        private int _managerId;
        private Employee? _employee;
        public AddEmployeeToManagerList(IEmployeeManagerRepository employeeManagerRepository, int managerId, Employee? employee) {
            _employeeManagerRepository = employeeManagerRepository;
            _managerId = managerId;
            _employee = employee;
        }
        public AddEmployeeToManagerListMemonto CreateMemento() {
            return new AddEmployeeToManagerListMemonto(_managerId, _employee);
        }
        public void RestoreMemento(AddEmployeeToManagerListMemonto memento) {
            _managerId = memento.ManagerId;
            _employee = memento.Employee;
        }
        public bool CanExecute() {
            // employee shouldn't be null
            if (_employee is null) return false;

            // employee should't be on the manager's list already
            if (_employeeManagerRepository.HasEmployee(_managerId, _employee.Id)) {
                return false;
            }            
            // orther potantial rule(s); ensure that an employee can only be added
            // to one manager's list at the same time etc.
            return true;
        }

        public void Execute() {
            if (_employee is null) return;
            _employeeManagerRepository.AddEmployee(_managerId, _employee);
        }

        public void Undo() {
            if (_employee is null) return;
            _employeeManagerRepository.RemoveEmployee(_managerId, _employee);
        }
    }
}

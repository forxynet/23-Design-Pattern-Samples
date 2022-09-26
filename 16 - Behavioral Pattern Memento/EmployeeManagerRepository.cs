
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento {
    public class EmployeeManagerRepository : IEmployeeManagerRepository {

        private List<Manager> _managers = new List<Manager>() {
            new Manager(1, "Kevin"),
            new Manager(2, "Hakan")
        };
        public void AddEmployee(int managerId, Employee employee) {
            // in real-life add additional input and error checks
            _managers.First(m => m.Id == managerId).Employees.Add(employee);    
        }

        public bool HasEmployee(int managerId, int employeeId) {
            // in real-life add additional input & and eror checks
            return _managers.First(m => m.Id == managerId).Employees.Any(m => m.Id == employeeId);
        }

        public void RemoveEmployee(int managerId, Employee employee) {
            // in real-life add additional input and error checks
            _managers.First(m=> m.Id == managerId).Employees.Remove(employee);
        }

        /// <summary>
        ///  For demo porpose write out the data store to the console window
        /// </summary>
        public void WriteDataStor() {
            foreach (var manager in _managers) {
                Console.WriteLine($"Manager {manager.Id}, {manager.Name}");
                if (manager.Employees.Any()) {
                    foreach (var employee in manager.Employees) {
                        Console.WriteLine($"\t Employee {employee.Id}, {employee.Name}");
                    }
                }
                else {
                    Console.WriteLine($"\t No employees.");
                }
            }
        }
    }
}

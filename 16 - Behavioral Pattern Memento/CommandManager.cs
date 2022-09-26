using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento {
    /// <summary>
    /// Invoker & Caretaker
    /// </summary>
    public class CommandManager {

        private readonly Stack<AddEmployeeToManagerListMemonto> _memontos = new();
        private AddEmployeeToManagerList? _command;
        public void Invoke(ICommand command) {

            // if the command has not stored yet, store it - we will
            // reuse it istead of storing different intences
            if (_command is null)
                _command = (AddEmployeeToManagerList)command;


            if (command.CanExecute()) {
                command.Execute();
                _memontos.Push(((AddEmployeeToManagerList)command).CreateMemento());
            }
        }
        public void Undo() {
            if (_memontos.Any()) {
                _command?.Undo();
            }
        }

        public void UndoAll() {
            while (_memontos.Any()) {
                _command?.RestoreMemento(_memontos.Pop());
                _command?.Undo();
            }
        }
    }
}

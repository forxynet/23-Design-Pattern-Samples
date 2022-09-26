using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor {
    //public interface IVisitor {
    //    void VisiCustomer(Customer customer);
    //    void VisiEmployee(Employee employee);
    //}

    /// <summary>
    /// Visitor (Alternative)
    /// </summary>
    public interface IVisitor {
        void Visit(IElement element);
    }
}

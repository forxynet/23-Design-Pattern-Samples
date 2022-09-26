using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Iterator {
    public interface IPeopleIterator {
        Person First();
        Person Next();
        bool IsDone { get; }
        Person CurrentItem { get; }
    }
}

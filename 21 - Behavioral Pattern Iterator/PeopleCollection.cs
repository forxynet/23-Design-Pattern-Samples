using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Iterator {
    public class PeopleCollection : List<Person>, IPeopleCollection {
        public IPeopleIterator CreateIterator() {
            return new PeopleIterator(this);
        }
    }
}

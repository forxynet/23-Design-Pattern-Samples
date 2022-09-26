using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Iterator {
    public class PeopleIterator : IPeopleIterator {
        private PeopleCollection _peopleColelction;
        private int _current = 0;
        public PeopleIterator(PeopleCollection peopleColelction) {
            _peopleColelction = peopleColelction;
        }

        public bool IsDone {
            get { return _current >= _peopleColelction.Count; }
        }

        public Person CurrentItem {
            get {
                return _peopleColelction.OrderBy(p => p.Name).ToList()[_current];
            }
        }

        public Person First() {
            _current = 0;
            return _peopleColelction.OrderBy(p => p.Name).ToList()[_current];
        }

        public Person Next() {
            _current++;

            if (!IsDone) 
                return _peopleColelction.OrderBy(p => p.Name).ToList()[_current];
            
            return null;            
        }
    }
}

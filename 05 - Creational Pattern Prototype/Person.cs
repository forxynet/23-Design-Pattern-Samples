﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype {
    public abstract class Person {
        public abstract string Name { get; set; }
        public abstract Person Clone(bool deepClone);
    }
}

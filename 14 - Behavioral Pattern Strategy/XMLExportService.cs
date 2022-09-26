﻿using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy {
    public class XMLExportService : IExportService {
        public void Export(Order order) {
            Console.WriteLine($"Exporting {order.Name} to XML");
        }
    }
}

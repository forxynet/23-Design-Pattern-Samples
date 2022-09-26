using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy {
    public class JsonExportService : IExportService {
        public void Export(Order order) {

           // var data = JsonConvert.SerializeObject(order);

            Console.WriteLine($"Exporting {order.Name} to Json");
        }
    }
}

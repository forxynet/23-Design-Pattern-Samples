using Behavioral_Pattern_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern_Observer {
    /// <summary>
    /// concreate object
    /// </summary>
    public class OrderService : TicketChangeNotifier {
        public void ComplateTicketSale(int artistId, int amount) {
            //change local datastore. Datastore ommitted in demo implementation
            Console.WriteLine($"{nameof(OrderService)} is changing its state.");

            //notify observers
            Console.WriteLine($"{nameof(OrderService)} is notifying observers.");
            Notify(new TicketChange(artistId, amount));
        }
    }
}

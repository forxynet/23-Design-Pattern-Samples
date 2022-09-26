using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern_Observer {
    public class TicketStockService : ITicketChangeListener {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange) {
            // update local datastore (datastore omitted in demo implementation)
            Console.WriteLine($"{nameof(TicketStockService)} notified " +
                $"of ticket change: artist {ticketChange.ArtistId}, amount " +
                $"{ticketChange.Amount}");
        }
    }
}

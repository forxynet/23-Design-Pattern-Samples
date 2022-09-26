using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern_Observer {
    public class TicketChangeNotifier {
        private List<ITicketChangeListener> _observers = new();

        public void AddObserver(ITicketChangeListener observer) {
            _observers.Add(observer);
        }
        public void RemoveObserver(ITicketChangeListener observer) {
            _observers.Remove(observer);
        }
        public void Notify(TicketChange ticketChange) {
            foreach (ITicketChangeListener observer in _observers) {
                observer.ReceiveTicketChangeNotification(ticketChange);
            }
        }
    }
}

namespace Behavioral_Pattern_Observer {
    public interface ITicketChangeListener {
        void ReceiveTicketChangeNotification(TicketChange ticketChange);
    }
}
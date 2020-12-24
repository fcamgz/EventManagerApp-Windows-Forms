using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1202_Assignment_1_GUI
{
    public class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        RSVPManager rsvpMan;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
            rsvpMan = new RSVPManager(1, maxCust * maxEvents);
        }

        //customer related methods
        public bool addCustomer(string fname, string lname, string phone)
        {
            return custMan.addCustomer(fname, lname, phone);
        }

        public Customer[] GetCustomers()
        {
            return custMan.GetCustomers();
        }

        public Event[] GetEvents()
        {
            return eventMan.GetEvents();
        }

        public RSVP[] GetRSVPs()
        {
            return rsvpMan.GetRSVPs();
        }

        public string customerList()
        {
            return custMan.getCustomerList();
        }

        public string getCustomerInfoById(int id)
        {
            return custMan.getCustomerInfo(id);
        }
        public bool deleteCustomer(int id)
        {
            return custMan.deleteCustomer(id);
        }

        public bool deleteEvent(int id)
        {
            return eventMan.deleteEvent(id);
        }

        public bool isValidCustomer(int id)
        {
            return custMan.customerExist(id);
        }

        // Event related methods
        public bool addEvent(string name, string venue, Date eventDate, int maxAttendee)
        {
            return eventMan.addEvent(name, venue, eventDate, maxAttendee);
        }

        public string eventList()
        {
            return eventMan.getEventList(rsvpMan);
        }

        public string getEventInfoById(int id)
        {
            return eventMan.getEventInfo(id);
        }

        public bool isValidEvent(int id)
        {
            return eventMan.eventExists(id);
        }

        //RSVP related Methods
        public bool addRSVP(int eventId, int custId)
        {
            Event eve = eventMan.getEvent(eventId);
            Customer cus = custMan.getCustomer(custId);
            if (rsvpMan.findRSVPByEveAndCus(eve, cus))
            {
                return false;
            }

            if (eve == null || cus == null)
            {
                return false;
            }
            return eve.addAttendee(cus) && cus.incrementNumberOfBookings() && rsvpMan.addRSVP(eve, cus);
        }

        public string rsvpList()
        {
            return rsvpMan.getRSVPList();
        }

        public string getRsvpInfoById(int id)
        {
            return rsvpMan.getRSVPInfo(id);
        }
    }
}

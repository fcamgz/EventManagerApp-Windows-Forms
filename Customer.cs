using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1202_Assignment_1_GUI
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;

        public Customer(int cId, string fname, string lname, string ph)
        {
            bookings = 0;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }

        public string getFullName() { return firstName + " " + lastName; }
        public string getPhone() { return phone; }
        public int getNumBookings() { return bookings; }

        public bool incrementNumberOfBookings()
        {
            bookings++;
            return true;
        }

        public bool decrementNumberOfBookings()
        {
            if (bookings - 1 >= 0)
            {
                bookings--;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            string s = "Customer " + customerId;
            s = s + "\nName: " + firstName + " " + lastName;
            s = s + "\nPhone: " + phone;
            s = s + "\nBookings: " + bookings;

            return s;
        }

    }
}

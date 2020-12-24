using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1202_Assignment_1_GUI
{
    public partial class RegistrationMenu : Form
    {
        EventCoordinator eCoord;
        public RegistrationMenu()
        {
            InitializeComponent();
        }

        public RegistrationMenu(EventCoordinator eCoord)
        {
            this.eCoord = eCoord;
            InitializeComponent();
        }

        public void updateTable()
        {
            this.dgvRegistrations.Rows.Clear();
            foreach (RSVP rsvp in this.eCoord.GetRSVPs())
                dgvRegistrations.Rows.Add(rsvp.getId(), rsvp.getEvent().getEventName(), rsvp.getCustomer().getFullName(), rsvp.getDate());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationMenu_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> cmbCustomerItems = new Dictionary<string, string>();

            foreach (Customer c in this.eCoord.GetCustomers()) {
                cmbCustomerItems.Add(Convert.ToString(c.getId()), c.getFullName());
            }

            cmbCustomers.DataSource = new BindingSource(cmbCustomerItems, null);
            cmbCustomers.DisplayMember = "Value";
            cmbCustomers.ValueMember = "Key";

            Dictionary<string, string> cmbEventsItems = new Dictionary<string, string>();

            foreach (Event ev in this.eCoord.GetEvents())
            {
                cmbEventsItems.Add(Convert.ToString(ev.getEventId()), ev.getEventName());
            }

            cmbEvents.DataSource = new BindingSource(cmbEventsItems, null);
            cmbEvents.DisplayMember = "Value";
            cmbEvents.ValueMember = "Key";


            updateTable();
        }

        private void btnAddRSVP_Click(object sender, EventArgs e)
        {
            int cmbEventsValue = Convert.ToInt32(((KeyValuePair<string, string>)cmbEvents.SelectedItem).Key);
            int cmbCustomersValue = Convert.ToInt32(((KeyValuePair<string, string>)cmbCustomers.SelectedItem).Key);

            if(!eCoord.addRSVP(cmbEventsValue, cmbCustomersValue))
            {
                MessageBox.Show("RSVP exists for particular Customer and Event","Message");
            }

            updateTable();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

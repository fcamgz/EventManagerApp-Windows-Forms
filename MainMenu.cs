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
    public partial class MainMenu : Form
    {
        EventCoordinator eCoord;
        
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(EventCoordinator eCoord)
        {
            this.eCoord = eCoord;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerOptions co = new CustomerOptions(eCoord);
            co.StartPosition = FormStartPosition.CenterScreen;
            co.Show();
        }

        private void btnEventOptions_Click(object sender, EventArgs e)
        {
            EventOptions eo = new EventOptions(eCoord);
            eo.StartPosition = FormStartPosition.CenterScreen;
            eo.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the Application ?","Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnRSVP_Click(object sender, EventArgs e)
        {
            RegistrationMenu rm = new RegistrationMenu(eCoord);
            rm.StartPosition = FormStartPosition.CenterScreen;
            rm.Show();
        }
    }
}

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
    public partial class CustomerOptions : Form
    {
        EventCoordinator eCoord;

        public CustomerOptions()
        {
            InitializeComponent();
        }
        
        public CustomerOptions(EventCoordinator eCoord)
        {
            this.eCoord = eCoord;
            InitializeComponent();
        }

        private void CustomerOptions_Load(object sender, EventArgs e)
        {
            this.updateTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void updateTable()
        {
            this.dgvCustomers.Rows.Clear();
            foreach (Customer customer in this.eCoord.GetCustomers())
                this.dgvCustomers.Rows.Add(customer.getId(), customer.getFirstName(), customer.getLastName(),customer.getPhone());  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.Columns[e.ColumnIndex].Name == "Delete") 
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    eCoord.deleteCustomer(Convert.ToInt32(dgvCustomers.CurrentRow.Cells["id"].Value));
                    updateTable();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fn = txtFirstName.Text;
            if (fn == "")
            {
                MessageBox.Show("Please enter Customer First Name","Input Required");
                return;
            }
            string ln = txtLastName.Text;
            if (ln == "")
            {
                MessageBox.Show("Please enter Customer Last Name", "Input Required");
                return;
            }
            string pn = txtPhone.Text;
            if (pn == "")
            {
                MessageBox.Show("Please enter Customer Phone Number", "Input Required");
                return;
            }
            eCoord.addCustomer(fn, ln, pn);
            updateTable();

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
        }
    }
}

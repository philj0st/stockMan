using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Controller controller = Controller.Instance;
            DAL dal = DAL.Instance;
            DataTable dtCustomers = dal.getCustomers();
            controller.initCustomersListFromDT(dtCustomers);

            customersCheckedListBox.DataSource = controller.Customers;
            //displays Customer.Name in ListBox
            //important to set after the DataSource has been set.
            customersCheckedListBox.DisplayMember = "CompanyName";
            customersCheckedListBox.ValueMember = "ID";

        }

        private void customersCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //use other event to write after checked prop has been changed
            Console.WriteLine(((sender as CheckedListBox).CheckedItems[0] as Customer).ID);
        }
    }
}

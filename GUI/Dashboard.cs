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
            //DataTable dtCustomers = dal.getCustomers();
            DataTable dtCustomers = dal.getTable("Customer");
            controller.Customers = controller.dtToCustomerList(dtCustomers);

            customersCheckedListBox.DataSource = controller.Customers;
            //displays Customer.Name in ListBox
            //important to set after the DataSource has been set.
            customersCheckedListBox.DisplayMember = "CompanyName";
            customersCheckedListBox.ValueMember = "ID";

            stockGridView.DataSource = dal.getStock(new int[2] { 1,2 }, new int[0], new int[1] {1});

        }

        private void customersCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //use other event to write after checked prop has been changed
            //Console.WriteLine(((sender as CheckedListBox).CheckedItems[0] as Customer).ID);
            MessageBox.Show((customersCheckedListBox.Items[e.Index] as Customer).CompanyName + "checked");
            customersCheckedListBox.SetItemChecked(1, true);
        }
    }
}

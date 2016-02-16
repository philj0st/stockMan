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
        BindingSource stockGridBindingSrc = new BindingSource();
        DAL dal;
        public Dashboard()
        {
            InitializeComponent();

            Controller controller = Controller.Instance;
            dal = DAL.Instance;

            //populate the controller with results from the db
            controller.addCustomersFromDt(dal.getTable("Customer"));
            controller.addSuppliersFromDt(dal.getTable("Supplier"));
            controller.addElementsFromDt(dal.getTable("Element"));

            initListView(ref customerCheckedListBox, ref controller.Customers, "CompanyName");
            initListView(ref supplierCheckedListBox, ref controller.Suppliers, "CompanyName");
            initListView(ref elementCheckedListBox, ref controller.Elements, "ElementName");

            stockGridView.DataSource = stockGridBindingSrc;
            updateStockGrid();
            
        }

        private void updateStockGrid() {
            int[] customerIds = new int[customerCheckedListBox.CheckedItems.Count];
            //cast CheckedItemCollection to a List<Customer> and generates array from it's Customer.ID properties
            customerIds = customerCheckedListBox.CheckedItems.Cast<Customer>().Select(x => x.ID).ToArray();

            int[] supplierIDs = new int[supplierCheckedListBox.CheckedItems.Count];
            supplierIDs = supplierCheckedListBox.CheckedItems.Cast<Supplier>().Select(x => x.ID).ToArray();

            int[] elementIDs = new int[elementCheckedListBox.CheckedItems.Count];
            elementIDs = elementCheckedListBox.CheckedItems.Cast<Element>().Select(x => x.ID).ToArray();

            //update GridView
            stockGridBindingSrc.DataSource = dal.getStock(customerIds, supplierIDs, elementIDs);
        }

        private void allCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //delay running code until all event side-effects have been completed.
            //in other words: invoke updateStockGrid() after ItemCheck Event has been completed.
            this.BeginInvoke(new MethodInvoker(updateStockGrid), null);
        }

        //generics -> http://stackoverflow.com/questions/20489423/pass-an-object-type-as-parameter
        private void initListView<T>(ref CheckedListBox list, ref BindingList<T> sourceListFromController, string displayMember) {
            list.DataSource = sourceListFromController;
            
            //displays Customer.Name in ListBox
            //important to set after the DataSource has been set.
            list.DisplayMember = displayMember;
            list.ValueMember = "ID";
        }
    }
}

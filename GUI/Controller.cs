using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Controller
    {
        private static Controller instance = null;

        private Controller() {
            Customers = new BindingList<Customer>();
            Suppliers = new BindingList<Supplier>();
            Elements = new BindingList<Element>();
        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        public BindingList<Customer> Customers;
        public BindingList<Supplier> Suppliers;
        public BindingList<Element> Elements;

        public void addCustomersFromDt(DataTable dt) {
            foreach (DataRow row in dt.Rows)
            {
                //Customers.Add(new Customer(row.Field<int>("ID"), row.Field<string>("CompanyName"), row.Field<string>("Address"), row.Field<int>("PLZ"), row.Field<string>("City"), row.Field<string>("Tel"), row.Field<string>("ContactName"), row.Field<string>("Email"), row.Field<int>("TypeID")));
                Customers.Add(new Customer() { ID = row.Field<int>("ID"), CompanyName = row.Field<string>("companyName") });
            }
        }

        public void addSuppliersFromDt(DataTable dt) {
            foreach (DataRow row in dt.Rows)
            {
                Suppliers.Add(new Supplier() { ID = row.Field<int>("ID"), CompanyName = row.Field<string>("companyName") });
            }
        }

        public void addElementsFromDt(DataTable dt) {
            foreach (DataRow row in dt.Rows)
            {
                Elements.Add(new Element() { ID = row.Field<int>("ID"), ElementName = row.Field<string>("elementName") });
            }
        }
    }
}

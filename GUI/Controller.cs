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

        private Controller() { }

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

        public BindingList<Customer> dtToCustomerList(DataTable dt) {
            BindingList<Customer> customers = new BindingList<Customer>();
            foreach (DataRow row in dt.Rows)
            {
                //Customers.Add(new Customer(row.Field<int>("ID"), row.Field<string>("CompanyName"), row.Field<string>("Address"), row.Field<int>("PLZ"), row.Field<string>("City"), row.Field<string>("Tel"), row.Field<string>("ContactName"), row.Field<string>("Email"), row.Field<int>("TypeID")));
                customers.Add(new Customer() { ID = row.Field<int>("ID"), CompanyName = row.Field<string>("companyName") });
            }
            return customers;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Customer
    {
        public Customer() {

        }

        public Customer( int id, string companyName, string address, int plz, string city, string tel, string contactName, string email, int typeId)
        {
            this.ID = id;
            this.CompanyName = companyName;
            this.Address = address;
            this.PLZ = plz;
            this.City = city;
            this.Tel = tel;
            this.ContactName = contactName;
            this.Email = email;
            this.TypeID = typeId;
        }

        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int PLZ { get; set; }
        public string City { get; set; }
        public string Tel { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public int TypeID { get; set; }

    }
}

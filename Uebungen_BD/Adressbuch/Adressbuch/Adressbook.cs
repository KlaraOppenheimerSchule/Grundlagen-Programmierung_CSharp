using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbook
{
    public abstract class Adressbook
    {
        private List<Contact> Contacts = new List<Contact>();
        private string Name { get; set; }
        private int ID { get; set; }


        public string ShowAll()
        {
            return Contacts.;
        }

        public string ShowByName(string name)
        {
            return name;
        }

        public Contact GetContact(int id)
        {
            return Contacts.Find(Contact.ID.Equals(id)) ;
        }
        public void AddContact(int id)
        {
            Contacts.Add(Contact);
            Contacts.Contact.ID = id
        }
    }
}

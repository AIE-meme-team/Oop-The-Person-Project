    using System;
using System.Collections.Generic;
using System.Text;

namespace Person_oop
{
    class Pearson
    {
        private string name;
        private string indentity;
        private string contact;
        private string address;
        private string email;

        public Pearson(string aName, string aIndentity, string aContact, string aAdress, string aEmail)
        {
            this.name = aName;
            this.indentity = aIndentity;
            this.contact = aContact;
            this.address = aAdress;
            this.email = aEmail;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if ( value != null)
                {
                    name = value;
                }
            }
        }

        public string Id
        {
            get { return this.indentity; }
            set
            {
                if (indentity != null)
                {
                    indentity = value;
                }
            }
        }

        public string Contact
        {
            get { return this.contact; }
            set
            {
                if (value != null)
                {
                    this.contact = value;
                }
            }
        }

        public string Adress
        {
            get { return this.address; }
            set
            {
                if (value != null)
                {
                    this.address = value;
                }
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null)
                {
                    this.email = value;
                }
            }
        }


        public string Display()
        {
            return "Name: "+this.name +"\nIdentity: "+this.indentity+"\nContact: "+this.contact+"\nAdress: "+this.address + "\nEmail: "+this.email;
        }
    }
}

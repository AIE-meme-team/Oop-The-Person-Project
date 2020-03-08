namespace Person_oop
{
    public class Person
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public string Contact { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public Person(string aName, string aIndentity, string aContact, string aAdress, string aEmail)
        {
            Name = aName;
            Id = aIndentity;
            Contact = aContact;
            Address = aAdress;
            Email = aEmail;
        }

        public override string ToString()
        {
            return $"Name:  {Name} \n Identity: {Id} \n Contact: {Contact} \n Adress: {Contact} \n Email: {Email}";
        }
    }
}

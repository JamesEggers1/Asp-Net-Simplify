using System.Collections.Generic;

namespace Simplify.Sample.Contacts
{
    public static class DataSource
    {
        private static List<Contact> _contacts = new List<Contact>(){
            new Contact() { Id = 1, FirstName = "James", LastName = "Eggers", City = "Kansas City", State = "MO" },
            new Contact() { Id = 2, FirstName = "John", LastName = "Smith", City = "Denver", State = "CO" },
            new Contact() { Id = 3, FirstName = "Jane", LastName = "Doe", City = "Lincoln", State = "NE" },
            new Contact() { Id = 4, FirstName = "Sarah", LastName = "Jane", City = "Des Moines", State = "IA" },
            new Contact() { Id = 5, FirstName = "Rose", LastName = "Tyler", City = "Tampa", State = "FL" },
            new Contact() { Id = 6, FirstName = "Donna", LastName = "Nobel", City = "Newark", State = "NJ" }};

        public static List<Contact> Contacts 
        {
            get { return _contacts; }
            set { _contacts = value; }
        }
    }
}
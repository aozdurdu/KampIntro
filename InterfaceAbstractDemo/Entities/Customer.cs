using System;

namespace InterfaceAbstractDemo
{
    public class Customer:IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public long NationalID { get; set; }
    }
}

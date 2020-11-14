using System;

namespace ModelLayer
{
    public class PersonModel
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public bool hasDiscount { get; set; }
        public decimal discount { get; set; }
    }
}

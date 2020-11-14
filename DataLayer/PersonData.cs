using DataLayer.Interfaces;
using ModelLayer;
using System;
using System.Collections.Generic;


namespace DataLayer
{
    public class PersonData : IPersonData
    {
        private static List<PersonModel> data { get; set; }
        public PersonData()
        {

            data = new List<PersonModel>
            {
                new PersonModel{id=1,fullName="Iliana Muñoz", age=22, email = "iliana@gmail.com",dateOfBirth = DateTime.Now, hasDiscount = true, discount = 1000 },
                new PersonModel{id=1,fullName="Juan Castro", age=29, email = "iliana@gmail.com",dateOfBirth = DateTime.Now, hasDiscount = false, discount = 0 }
            };

        }

        public List<PersonModel> GetList()
        {
            return data;
        }


        public void Add(PersonModel person)
        {
            data.Add(person);
        }

    }
}

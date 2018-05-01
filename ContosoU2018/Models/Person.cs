using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Models
{
    public abstract class Person

        //Person Properties : Characteristics
        /*
         * These properties will become database fields within the person  table.
         * by using the entitity framework core.
         * The ID property will become the Primary Key Column of the database table that corresponds to this class
         * (Person)
         * By default the EF(Entity Framework) interprets property.
         * By default the EF interpret  a property thats named ID or ClassNameID as the PK 
         * for example:
         * --ID
         * --PersonID
         * */
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        
        public string Email { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Province { get; set; }

        //Read only properties
        [Display(Name = "Name")]
        public string FullName
        {
            get
            {
                //return LastName + ", " + FirstName;
                return FirstName + ", " + LastName;
            }
        }
       
        public string IDFullName
        {
            get
            {
                return "(" + ID + ")" + LastName + ", " + FirstName;
            }
        }

    }
}

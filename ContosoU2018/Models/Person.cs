using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required]
        [StringLength(50,ErrorMessage ="First Name cannot be longer then 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(65, ErrorMessage = "Last Name cannot be longer then 65 characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(150)] //Only requirement is the size, it will use a default error message.
        public string Address { get; set; }

        [Required]
        [StringLength(60)]
        public string City { get; set; }

        [Display(Name ="Postal Code")]
        [Required]
        [StringLength(7)]
        [Column(TypeName ="nchar(7)")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(2)]
        [Column(TypeName = "nchar(2)")]
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

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoU2018.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        /*
         * You can turn of IDENTITY (on by default) by using the option above
         * you have the following 3 options
         * None - Database does not generate a value.
         * Identity - Database Generates a value when a row is inserted.
         * Computed - Database generates a value when a row is inserted or updated.
         * */

        [Display(Name ="Course Number")]
        public int CourseID{ get; set; } //PK

        [StringLength(50,MinimumLength =3)]
        [Required]
        public string Title { get; set; }

        [Range(0,5)]//Possible Values are: 0,1,2,3,4,5
        public int Credits { get; set; }

        //Navigation properties
        //1: One course to many enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
using System.Collections.Generic;
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
         * Computer - Database generates a value when a row is inserted or updated.
         * */
        public int CourseID{ get; set; } //PK
        public string Title { get; set; }
        public int Credits { get; set; }

        //Navigation properties
        //1: One course to many enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Models
{
    public class Student:Person //student inherits from person
    {
        //Student specific properties
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)] //Removed the time out of edit.

        public DateTime EnrollmentDate { get; set; }

        //1 student: Many enrollments - this is the navigation property between student and enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        /* The enrollments property is a navigation property (EF Core). Navigation properties hold other
         * entities that are related to this entity. In this case, the enrollments property of a student
         * entity will hold all of the enrollments that are related to that student.
         * 
         * In other words, if a given student row in the database has two related enrollment rows 
         * (rows that contain that student's PD value in thier foreign key column), that student entity's
         * enrollment navigation property will contain those two enrollment entities.
         * 
         * Navigation properties are typically defined as virtual so that they can take advantage of certain EF functionality
         * such as Lazy loading.
         * Note: Lazy loading is not yet available in EF core (But has in EF 5,6)
         *
         * Lazy loading is not enabled by default - so that means when a particular student entity is
         * instantiated it will automatically bring all related entities.
         * 
         */

    }
}

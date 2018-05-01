namespace ContosoU2018.Models
{
    public class Enrollment
    {
        /*
         * The EnrollmentID property will be the primary key: this entity used the ClassNameID pattern
         * instead of the ID by itself that you have in the student entity.
         * 
         * */

        public int EnrollmentID { get; set; }//pk

        public int CourseID { get; set; }//FK with corresponding nagivation property course

        public int StudentID { get; set; }//FK with corresponding navigation property student

        public Grade? Grade { get; set; } //? Meaning is Nullable. because we dont start with a grade

        //Navigation property. each enrollment must be for one student.
        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }

    }
    //Grade enumeration
    public enum Grade
    {
        A,B,C,D,F
    }

}
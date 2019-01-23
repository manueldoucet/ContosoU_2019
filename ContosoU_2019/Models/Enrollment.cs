using System.ComponentModel.DataAnnotations;

namespace ContosoU_2019.Models
{
    public class Enrollment
    {

        public int EnrollmentID { get; set; }//pk

        public int courseID { get; set; }//fk to course entity

        public int studentID { get; set; }//fk to student entity


        //Show "no grade" in client instead of blank when grade is NULL
        [DisplayFormat(NullDisplayText = "No Grade Yet")]
        public Grade? Grade { get; set; }//? NULLABLE: because we dont get a grade upon registration


        //Navigation Property
        public virtual Student Student { get; set; } //many enrollments to 1 student
        public virtual Course Course { get; set; }
    }

    //grade enumeration
    public enum Grade
    { A, B, C, D, F }
}
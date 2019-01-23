using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoU_2019.Models
{
    public class Course
    {   

        //Remove the identity - autonumber feature 
        //Choices are computed , identity, none
        //Computed: database generates a value when row is inserted or updated
        //Identity: Database generates a value when row is inserted
        //none : data does not generate a value
        //User will have to enter the courseID manually 

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Course Number")]
        public int CourseID { get; set; }//PK

        [StringLength(50,MinimumLength=3)]
        [Required]
        public string Title { get; set; }
        public int credits { get; set; }

        //Calculated readonly property
        //return the course id and course title
        public string CourseIDTitle
        {
            get
            {
                return CourseID + ": " + Title;
            }
        }

        //Navigation Properties
        //1 course many enrollments 
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
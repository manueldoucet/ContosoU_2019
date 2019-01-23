using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU_2019.Models
{
    //mdoucet: part 2: Create the data models 
    //1. Create the person abstract class (inheritence)
    public abstract class person
    {        
        //the id property will become the PK column of the database table 
        //by default entity framework interprets a property name "ID" or "classnameID" as the
        //PK 

            //String types will become nvarchar 
            //without a stringlength they are set to max: nvarchar(max)
        public int ID { get; set; }

        [Required]
        [StringLength(50,ErrorMessage="First Name cannot be longer than 50 characters")]
        [Display(Name ="First name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(65, ErrorMessage = "Last Name cannot be longer than 50 characters")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(150)] 
        public string address { get; set; }

        [Required]
        [StringLength(60)]
        public string City { get; set; }

        [Required]
        [StringLength(7)]
        [Column(TypeName = "nchar(7)")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(2)]
        [Column(TypeName = "nchar(2)")]
        public string Province { get; set; }

        //Fullname: readonly property
        [Display(Name = "Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        //IdFullName: Read only property 
        public string IDFullName
        {
            get
            {
                return "("+ ID +")" + LastName + ", " + FirstName;
            }
        }

        //Fulladdress 
        public string FullAddress
        {
            get
            {
                return address = ", " +
                       City + ", " +
                       Province + ", " +
                       PostalCode;
            }
        }





    }
}

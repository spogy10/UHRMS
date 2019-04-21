using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHRMS.Models
{
    public class Student
    {
        [Key]
        public string studentId { get; set; }

        public virtual ApplicationUser Applicant { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string gender { get; set; }

        public string permanentAddress { get; set; }

        public int studentPhoneNumber { get; set; }

        public string faculty { get; set; }

        public string programme { get; set; }

        public int durationOfProgramme { get; set; }

        public string emergencyContactName1 { get; set; }
        public string emergencyContactNumber1 { get; set; }
        public string emergencyContactAddress1 { get; set; }


        public string emergencyContactName2 { get; set; }
        public string emergencyContactNumber2 { get; set; }
        public string emergencyContactAddress2 { get; set; }


        public virtual BoardingApplicationForm BoardingApplicationForm { get; set; }




    }
}
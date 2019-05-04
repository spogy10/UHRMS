using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using Microsoft.Owin.Security;

namespace UHRMS.Models
{
    public class BoardingApplicationForm
    {

        //TO BE COMPLETED BY ALL APPLICANTS 
        //SECTION A
        //PERSONAL DETAILS

        //[Required]
        [Key]
        [ForeignKey("Student")]
        public string studentId { get; set; }

        public virtual ApplicationUser Applicant { get; set; }

        public string studentStatus { get; set; }

        //[Required]
        public string ApplicantType { get; set; }

        public static IList<string> ApplicantTypeList = new List<string>()
        {
            "New Student",
            "Returning Resident Student",
            "Returning Non-Resident Student",
            "Community College Transfer",
            "Inter Department/Faculty Transfer Student"
        };

        public string title { get; set; }

        //[Required]
        public string firstName { get; set; }

        //[Required]
        public string fmiddleInitial { get; set; }


        //[Required]
        public string lastName { get; set; }

        //[Required]
        public string gender { get; set; }


        //[Required]
        public DateTime? DOB { get; set; }


        //[Required]
        public string nationality { get; set; }

        public string religion { get; set; }

        public string denomination { get; set; }

        public int homeTelephone { get; set; }

        public int mobileTelephone { get; set; }

        public int workTelephone { get; set; }


        //[Required]
        public string email { get; set; }


        //CONTACT DETAILS

        public string postOfficeBox { get; set; }

        public string street { get; set; }

        public string town { get; set; }

        public string parish { get; set; }

        public string country { get; set; }



        public string mailingPostOfficeBox { get; set; }

        public string mailingStreet { get; set; }

        public string mailingTown { get; set; }

        public string mailingParish { get; set; }

        public string mailingCountry { get; set; }

        public string emergencyContactName1 { get; set; }

        public string emergencyContactRelationship1 { get; set; }
        public string emergencyContactMobileNumber1 { get; set; }

        public string emergencyContactMWorkNumber1 { get; set; }
        public string emergencyContactAddress1 { get; set; }


        public string emergencyContactName2 { get; set; }

        public string emergencyContactRelationship2 { get; set; }
        public string emergencyContactMobileNumber2 { get; set; }

        public string emergencyContactMWorkNumber2 { get; set; }
        public string emergencyContactAddress2 { get; set; }



        //MEDICAL INFORMATION

        public string familyDoctorName { get; set; }

        public string familyDoctorNumber { get; set; }

        public string medicalConditions { get; set; }

        public string specialNeeds { get; set; }



        //ACADEMIC INFORMATION

        //[Required]
        public string faculty { get; set; }
        public static IList<string> FacultyList = new List<string>()
        {
            "College of Health Sciences (COHS)",
            "College of Business and Management (COBAM)",
            "Faculty of Engineering and Computing (FENC)",
            "Faculty of Law (FOL)",
            "Faculty of Science and Sport (FOSS)",
            "Joint Colleges of Medicine, Oral Health & Veterinary Sciences"
        };

        //[Required]
        public string school { get; set; }
        public static IList<string> SchoolList = new List<string>()
        {
            "New Student",
            "Returning Resident Student",
            "Returning Non-Resident Student",
            "Community College Transfer",
            "Inter Department/Faculty Transfer Student"
        };


        //[Required]
        public string programme { get; set; }

        //[Required]
        public string programmeMode { get; set; }

        //[Required]
        public int yearOfStudy { get; set; }

        //[Required]
        public string BoardingPeriod { get; set; }

        public string licensePeriod { get; set; }

        //[Required]
        public string hallPreference { get; set; }


        public string vehicleType { get; set; }

        public string vehicleModel { get; set; }

        public string vehicleMake { get; set; }

        public string registrationNumber { get; set; }


        //TO BE COMPLETED BY ALL APLICANTS
        //SECTION B
        //FINANCIAL INFORMATION

        public string fatherOccupation { get; set; }

        public string motherOccupation { get; set; }

        public string guardianOccupation { get; set; }

        public int familyBirthPosition { get; set; }

        public int NumberOfSiblings { get; set; }

        public int numberOfDependants { get; set; }

        public bool isFatherFinacing { get; set; }

        public bool isMotherFinacing { get; set; }

        public bool areYouFinancing { get; set; }

        public string financeer { get; set; }

        public bool slbQuestion { get; set; }

        public bool requestedSponsorship { get; set; }

        public bool requestedGrant { get; set; }

        public string scholarshipsGranted { get; set; }


        //public string scholarshipsGrantedAmount { get; set; }


        //EXTRA CURRICULAR ACTIVITIES ONLY NEW APPLICANTS
        //SECTION C


        public string extraCurriculars1 { get; set; }


        public string extraCurriculars2 { get; set; }


        public string extraCurriculars3 { get; set; }


        public string extraCurriculars4 { get; set; }


        public string extraCurriculars5 { get; set; }



        //SKILLS


        public string skills1 { get; set; }

        public string skills2 { get; set; }

        public string skills3 { get; set; }

        public string skills4 { get; set; }

        public string skills5 { get; set; }

        //ATTRIBUTES
        public string attributes1 { get; set; }

        public string attributes2 { get; set; }

        public string attributes3 { get; set; }

        public string attributes4 { get; set; }

        public string attributes5 { get; set; }



        //[Required]
        public string reasonOfApplication { get; set; }



        //RETURNING STUDENTS ONLY

        //SECTION D
        
        public string hallBlock { get; set; }

        public int roomNumber { get; set; }

        public int yearsOnHall { get; set; }

        public string hallCommiteesServed { get; set; }


        public string hallActivitiesInvolved { get; set; }

        public string reasonReturning { get; set; }



        //SUMMER STUDENTS ONLY

        //SECTION E

        public DateTime? expectedToStart { get; set; }

        public DateTime? expectedToDepart { get; set; }

        public virtual Student Student { get; set; }


        public bool FormComplete { get; set; }


    }
}
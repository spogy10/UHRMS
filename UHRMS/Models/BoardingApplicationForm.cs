using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.Owin.Security;

namespace UHRMS.Models
{
    public class BoardingApplicationForm
    {

        //TO BE COMPLETED BY ALL APPLICANTS 
        //SECTION A
        //PERSONAL DETAILS

        public int Id { get; set; }

        public ApplicationUser Applicant { get; set; }

        public string studentStatus { get; set; }

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
        public string firstName { get; set; }

        public string fmiddleInitial { get; set; }


        public string lastName { get; set; }

        public string gender { get; set; }


        public DateTime DOB { get; set; }


        public string nationality { get; set; }

        public string religion { get; set; }

        public string denomination { get; set; }

        public int homeTelephone { get; set; }

        public int mobileTelephone { get; set; }

        public int workTelephone { get; set; }


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

        public string faculty { get; set; }
        public string school { get; set; }
        public Student studentId { get; set; }


        public string programme { get; set; }

        public string programmeMode { get; set; }

        public int yearOfStudy { get; set; }

        public string BoardingPeriod { get; set; }

        public string licensePeriod { get; set; }

        public string hallPreference { get; set; }

        public string hallPreferencQuestion { get; set; }


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

        public DateTime expectedToStart { get; set; }

        public DateTime expectedToDepart { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using UHRMS.Models;

namespace UHRMS.Controllers
{
    public class BoardingApplicationFormController : Controller
    {
        private readonly ApplicationDbContext context;

        public BoardingApplicationFormController()
        {
            context = new ApplicationDbContext();
        }


        // GET: BoardingApplicationForm
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BoardingApplicationForm form)
        {
            //todo:add form to database
            if (ModelState.IsValid)
            {
                string id = User.Identity.GetUserId();
                Student student = context.Students.FirstOrDefault(x => x.studentId == id);
                student.firstName = form.firstName;
                student.lastName = form.lastName;
                student.gender = form.gender;
                student.permanentAddress = form.street + " " + form.town + " " + form.parish + " " + form.country;
                student.studentPhoneNumber = form.mobileTelephone;
                student.faculty = form.faculty;
                student.programme = form.programme;
                student.emergencyContactName1 = form.emergencyContactName1;
                student.emergencyContactAddress1 = form.emergencyContactAddress1;
                student.emergencyContactNumber1 = form.emergencyContactMobileNumber1;

                student.emergencyContactName2 = form.emergencyContactName2;
                student.emergencyContactAddress2 = form.emergencyContactAddress2;
                student.emergencyContactNumber2 = form.emergencyContactMobileNumber2;

                form.studentId = id;
                form.Student = student;
                context.BoardingForms.Add(form);

                student.BoardingApplicationForm = form;

                context.SaveChanges();
            }

            

            return RedirectToAction("Index", "Home");
        }

    }
}
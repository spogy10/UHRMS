using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using UHRMS.Models;

namespace UHRMS.Controllers
{
    [Authorize(Roles = "Student")]
    public class BoardingApplicationFormController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BoardingApplicationFormController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: BoardingApplicationForm
        public ActionResult Create()
        {
            string id = User.Identity.GetUserId();
            BoardingApplicationForm form = _context.BoardingForms.FirstOrDefault(x => x.studentId == id);
            if (form != null)
            {
                if (form.FormComplete)
                {
                    return RedirectToAction("Applied", "BoardingApplicationForm");
                }
                else
                {
                    return View(form);
                }
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BoardingApplicationForm form)
        {
            if (ModelState.IsValid)
            {
                //todo:add form to database
                string id = User.Identity.GetUserId();
                Student student = _context.Students.FirstOrDefault(x => x.studentId == id);
                BoardingApplicationForm DatabaseForm = _context.BoardingForms.FirstOrDefault(x => x.studentId == id);
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

                form.FormComplete = true;
            

                form.studentId = id;
                form.Student = student;
                DatabaseForm = form;
                _context.BoardingForms.Add(DatabaseForm);

                student.BoardingApplicationForm = DatabaseForm;

                _context.SaveChanges();
            }



            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(BoardingApplicationForm form)
        {
            //todo:add form to database
            string id = User.Identity.GetUserId();
            Student student = _context.Students.FirstOrDefault(x => x.studentId == id);
            BoardingApplicationForm DatabaseForm = _context.BoardingForms.FirstOrDefault(x => x.studentId == id);
            form.FormComplete = false;
            form.studentId = id;
            form.Student = student;
            DatabaseForm = form;
            _context.BoardingForms.Add(DatabaseForm);

            student.BoardingApplicationForm = DatabaseForm;

            _context.SaveChanges();



            return RedirectToAction("Index", "Home");
        }

        public ActionResult Applied()
        {
            string id = User.Identity.GetUserId();
            BoardingApplicationForm form = _context.BoardingForms.FirstOrDefault(x => x.studentId == id);
            if (form != null)
            {
                if (form.FormComplete)
                {
                    return View();
                }
            }
            return RedirectToAction("Create", "BoardingApplicationForm");
        }

    }
}
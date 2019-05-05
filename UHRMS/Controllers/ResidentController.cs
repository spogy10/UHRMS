using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using UHRMS.Models;

namespace UHRMS.Controllers
{
    //[Authorize(Roles = "Resident")]
    public class ResidentController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ResidentController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult CheckIn()
        {
            //todo: make cancel button link to portal home
            var hallSelectList = _context.Dorms.Select(p => new
            {
                Text = p.dormId,
                Value = p.dormId
            });

            ViewBag.HallSelectList = new SelectList(hallSelectList, "Value", "Text");

            if (ViewBag.RoomNumberError == null)
            {
                ViewBag.RoomNumberError = false;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckIn(CheckInForm form)
        {
            if (ModelState.IsValid)
            {
                var room = _context.Rooms.FirstOrDefault(r => form.Room.roomId == r.roomId);
                if (room == null)
                {
                    ViewBag.RoomNumberError = true;
                    return RedirectToAction("CheckIn");
                }
                string id = User.Identity.GetUserId();
                form.ApplicationUser = _context.Users.FirstOrDefault(u => u.Id == id);
                _context.CheckInForm.Add(form);
                _context.SaveChanges();
            }
            return null;
        }
    }
}
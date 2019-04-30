using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using UHRMS.Models;

namespace UHRMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController()
        {
            _context = new ApplicationDbContext();
            _userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(_context));
        }

        // GET: Admin
        public ActionResult ManageUser()
        {

            var userList = (from user in _context.Users
                select new
                {
                    UserId = user.Id,
                    user.Email,
                    RoleNames = (from userRole in user.Roles
                        join role in _context.Roles on userRole.RoleId
                            equals role.Id
                        select role.Name).ToList()
                }).ToList().Select(p => new ManageUserViewModel()

            {
                ID = p.UserId,
                Email = p.Email,
                Roles = p.RoleNames
            });

            var roles = _context.Roles.Select(r => new {
                RoleName = r.Name
            }).ToList();
            ViewBag.Roles = new MultiSelectList(roles, "RoleName", "RoleName");


            return View(userList);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<ActionResult> ManageUser(FormCollection form)
        {
            var id = form["Email"];
            var roles = form["Roles"].Split(',');
            var currentRoles = form["CurrentRoles"].Split(',');

            
            var result1 = await _userManager.RemoveFromRolesAsync(id, currentRoles);

            var result2 = await _userManager.AddToRolesAsync(id, roles);

            return RedirectToAction("ManageUser");
        }

    }
}
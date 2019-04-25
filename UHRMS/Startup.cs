using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using UHRMS.Models;

[assembly: OwinStartupAttribute(typeof(UHRMS.Startup))]
namespace UHRMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            SetUpRoles();
        }

        private void SetUpRoles()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


                
            if (!roleManager.RoleExists("Admin"))
            {

                   
                var role = new IdentityRole
                {
                    Name = "Admin"
                };
                roleManager.Create(role);

                               

                var user = new ApplicationUser //todo: take out
                {
                    Id = "0000000",
                    UserName = "admin",
                    Email = "admin@email.com"
                    
                };
               
                string userPWD = "P@$$WorD1!";

                var chkUser = userManager.Create(user, userPWD);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Admin");

                }
            }

              
            if (!roleManager.RoleExists("Student"))
            {
                var role = new IdentityRole
                {
                    Name = "Student"
                };
                roleManager.Create(role);

            }

            if (!roleManager.RoleExists("ApprovedApplicant"))
            {
                var role = new IdentityRole
                {
                    Name = "ApprovedApplicant"
                };
                roleManager.Create(role);
            }
        }
    }
}

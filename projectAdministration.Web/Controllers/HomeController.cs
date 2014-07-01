using projectAdministration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projectAdministration.Domain;

namespace projectAdministration.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserRepository userRepository = null;
 
        public HomeController()
        {
            //this.repository = new GenericRepository<User>();
            this.userRepository = new UserRepository();
        }
 
        public HomeController(IUserRepository userRepository)
        {
             this.userRepository = userRepository;
        }

        public ActionResult Index()
        {
            
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var allUsers = userRepository.GetUsers();
            
            return View(allUsers);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

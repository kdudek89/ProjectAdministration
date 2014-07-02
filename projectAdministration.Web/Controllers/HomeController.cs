using projectAdministration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projectAdministration.Domain;
using projectAdministration.Data.Interfaces;

namespace projectAdministration.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork uow = null;
        private readonly IRepository<User> userRepository = null;
 
        public HomeController()
        {
            uow = new UnitOfWork();
            userRepository = new Repository<User>(uow);
        }

        public HomeController(IUnitOfWork uow, IRepository<User> userRepository)
        {
            this.uow = uow;
            this.userRepository = userRepository;
        }

        public ActionResult Index()
        {
            
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var allUsers = userRepository.All.Where(e => e.Name=="Kamil");

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
        protected override void Dispose(bool disposing)
        {
            if (userRepository != null)
                userRepository.Dispose();
            if (uow != null)
                uow.Dispose();
            base.Dispose(disposing);
        }
    }
}

using projectAdministration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using projectAdministration.Web.Models;
using projectAdministration.Domain;
using projectAdministration.Data.Interfaces;

namespace projectAdministration.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork uow = null;
        private readonly IRepository<People> peopleRepository = null;
        private readonly IMappingEngine mapper = null;
 
        public HomeController()
        {
            uow = new UnitOfWork();
            peopleRepository = new Repository<People>(uow);
            mapper = Mapper.Engine;
        }

        public HomeController(IUnitOfWork uow, IRepository<People> peopleRepository, IMappingEngine mapper)
        {
            this.uow = uow;
            this.peopleRepository = peopleRepository;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Display Users !";
           // var allUsers = peopleRepository.All.Where(e => e.Name == "Kamil").FirstOrDefault();
            var allUsers = peopleRepository.Find(1);
            PeopleDTO employee = mapper.Map<People, PeopleDTO>(allUsers);

            //IEnumerable<PeopleDTO> employee = mapper.Map<People, PeopleDTO>(allUsers);
            //var result = mapper.Map<User, UserDTO>(allUsers);
            return View(employee);
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
            if (peopleRepository != null)
                peopleRepository.Dispose();
            if (uow != null)
                uow.Dispose();
            base.Dispose(disposing);
        }
    }
}

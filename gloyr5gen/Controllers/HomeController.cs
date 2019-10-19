using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gloyr5gen.Entity;
using gloyr5gen.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace gloyr5gen.Controllers
{
    public class HomeController : Controller
    {
        private IAdvertisementRepository repository;
        private IUnitOfWork uow;
        public HomeController(IUnitOfWork _uow,IAdvertisementRepository _repository)
        {
            repository = _repository;
            uow = _uow;
        }
        public IActionResult Index(string q)
        {
            var query = uow.Advertisements.GelAll().Where(i => i.IsApproved && i.IsHome);
            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(i => i.ilanName.Contains(q) || i.sehir.Contains(q));
            }
            return View(uow.Advertisements.GelAll().Where(i=>i.IsApproved && i.IsHome).ToList());
        }
        public IActionResult Details(int id)
        {
            return View(repository.Get(id));
        }

        public IActionResult Create()
        {
            var advertismnt = new Advertisement() { ilanName = "Muhasebeci", calismasekli = "Tam Zamanlı" };
            uow.Advertisements.Add(advertismnt);
            uow.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
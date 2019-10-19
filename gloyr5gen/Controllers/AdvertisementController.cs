 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gloyr5gen.Models;
using gloyr5gen.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gloyr5gen.Controllers
{
    public class AdvertisementController : Controller
    {
        public int PageSize = 2;
        private IAdvertisementRepository repository;
        private ICategoryRepository repository2;
        private IUnitOfWork uow;
        public AdvertisementController(IAdvertisementRepository _repository, IUnitOfWork _uow, ICategoryRepository _repository2)
        {
            repository = _repository;
            uow = _uow;
            repository2 = _repository2;
        }
        [HttpGet]
        public IActionResult Index(string q)
        {
            var query = repository.GelAll().Where(i => i.IsApproved && i.IsHome);
            if (!string.IsNullOrEmpty(q))
            {
                q = q.ToLower();
                query = query.Where(i => i.ilanName.ToLower().Contains(q) || i.tecrube.ToLower().Contains(q)|| i.firmasektoru.ToLower().Contains(q) || i.aciklama.ToLower().Contains(q));
            }
            return View(query.ToList());
            
        }

        public IActionResult List(string category,int page = 1)
        {
            var advertisements = repository.GelAll();
            if (!string.IsNullOrEmpty(category))
            {
                advertisements = advertisements
                .Include(i => i.AdvertisementCategories)
                .ThenInclude(i => i.Category)
                .Take(15)
                .Where(i => i.AdvertisementCategories.Any(a=>a.Category.CategoryName==category));
            }

            var count = advertisements.Count();

            advertisements = advertisements.Skip((page - 1) * PageSize).Take(PageSize);
            return View(
                new AdvertisementListModel()
                {
                    Advertisements = advertisements,
                    PagingInfo = new PagingInfo()
                    {
                        CurrentPage = page,
                        ItemsPerPage = PageSize, 
                        TotalItems = count
                    }}
                );
        }

        public IActionResult Details(int id)
        {
            return View
                (
                repository.GelAll()
                .Where(i=> i.AdvertisementId == id)
                .Include(i=> i.CalismaSeklis)
                .Include(i=> i.Sehirs)
                .Include(i=> i.AdvertisementCategories)
                .ThenInclude(i=> i.Category)
                .Select(i=> new AdvertisementDetailsModel()
                {
                    Advertisement = i,
                    AdvertisementCalismaSeklis = i.CalismaSeklis,
                    Advertisementsehirs = i.Sehirs,
                    Categories = i.AdvertisementCategories.Select(a=>a.Category).ToList()
                })
                .FirstOrDefault());
        }

        public IActionResult Search(string category, string q, string e, string c, int page = 1)
        {
            var advertisements = repository.GelAll();
            var categories = repository2.GelAll();
            if (!string.IsNullOrEmpty(q))
            {
                q = q.ToLower();
                advertisements = advertisements.Include(i => i.AdvertisementCategories).ThenInclude(i => i.Category).Where(i => i.AdvertisementCategories.Any(a => a.Category.CategoryName.ToLower().Contains(q)));
                advertisements = advertisements.Where(i => i.ilanName.ToLower().Contains(q) || i.tecrube.ToLower().Contains(q) || i.firmasektoru.ToLower().Contains(q) || i.aciklama.ToLower().Contains(q));
            }
            if (!string.IsNullOrEmpty(e))
            {
                advertisements = advertisements.Where(i => i.sehir.Contains(e) || i.ulke.Contains(e) || i.acikadres.Contains(e));
            }

            if (!string.IsNullOrEmpty(c))
            {
                advertisements = advertisements.Where(i => i.calismasekli.Contains(c) || i.pozisyonseviyesi.Contains(c) || i.egitimdurumu.Contains(c));
            }
            if (!string.IsNullOrEmpty(category))
            {
                advertisements = advertisements
                .Include(i => i.AdvertisementCategories)
                .ThenInclude(i => i.Category)
                .Take(15)
                .Where(i => i.AdvertisementCategories.Any(a => a.Category.CategoryName == category));
            }

            var count = advertisements.Count();

            advertisements = advertisements.Skip((page - 1) * PageSize).Take(PageSize);
            return View(
                new AdvertisementListModel()
                {
                    Advertisements = advertisements,
                    PagingInfo = new PagingInfo()
                    {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = count
                    }
                }
                );
        }
    }
}
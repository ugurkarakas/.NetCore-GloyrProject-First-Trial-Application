using gloyr5gen.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Components
{
    public class FeaturedAdvertisements : ViewComponent
    {
        private IAdvertisementRepository repository;
        public FeaturedAdvertisements(IAdvertisementRepository _repository)
        {
            repository = _repository; 
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.GelAll().Where(i=>i.IsApproved && i.IsFeatured).ToList());
        }
    }

}

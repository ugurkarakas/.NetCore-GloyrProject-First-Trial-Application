using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gloyr5gen.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace gloyr5gen.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository repository;
        public CategoryController(ICategoryRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult Index()
        {
            var cat = repository.GetByName("Yazılım");
            return View(cat);
        }
    }
}
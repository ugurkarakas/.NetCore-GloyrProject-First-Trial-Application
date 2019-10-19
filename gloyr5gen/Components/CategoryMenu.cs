﻿using gloyr5gen.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Components
{
    public class CategoryMenu : ViewComponent
    {
        private ICategoryRepository repository;
        public CategoryMenu(ICategoryRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.GetAllWithAdvertisementCount());
        }
    }
}

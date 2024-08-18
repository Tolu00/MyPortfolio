﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperienceComponentsPartial : ViewComponent
    {
        MyPortfolioContext MyPortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = MyPortfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}

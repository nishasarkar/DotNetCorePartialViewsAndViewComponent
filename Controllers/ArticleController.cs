using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            PostViewModel model = new PostViewModel
            {
                Id = 1,
                Title = "What is ASP.NET Core",
                Author = "Nisha Sarkar",
                Body = "ASP.NET Core is an open-source framework for building UI and API..."
            };
            return View(model);

        }
    }
}

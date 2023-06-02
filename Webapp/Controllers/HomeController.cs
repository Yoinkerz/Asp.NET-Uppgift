using Microsoft.AspNetCore.Mvc;
using Webapp.Models.ViewModels;

namespace Webapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                BestCollection = new GridCollectionViewModel
                {
                    Title = "Best Collection",
                    Categories = new List<string> { "All", "Bag", "Dress", "Decoration", "Essentials", "Interior", "Laptops", "Mobile", "Beauty" },
                    GridItems = new List<GridCollectionItemViewModel>
                    {
                        new GridCollectionItemViewModel {Id = "1" , Title = "Apple watch series", Price = 1800, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel {Id = "2" , Title = "Table Lamp", Price = 90, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel {Id = "3" , Title = "laptop thinkpad lenovo", Price = 1000, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel {Id = "4" , Title = "Wall Lamp", Price = 20, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel {Id = "5" , Title = "Gumshoes black fashion", Price = 35, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel {Id = "6" , Title = "Woman white dress", Price = 28, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel {Id = "7" , Title = "Kettle water boiler", Price = 47, ImageUrl = "images/placeholders/270x295.svg" },
                        new GridCollectionItemViewModel {Id = "8" , Title = "Congee cooking rice cooker", Price = 60, ImageUrl = "images/placeholders/270x295.svg" },
                    }
                }
            };

            return View(viewModel);
        }
    }
}

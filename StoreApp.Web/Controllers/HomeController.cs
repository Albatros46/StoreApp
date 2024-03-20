using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;

namespace StoreApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public int pageSize = 10;
        private IStoreRepository _storeRepository;

        public HomeController(IStoreRepository storeRepository)
        {
            this._storeRepository = storeRepository;
        }

        public IActionResult Index(int page=1)
        {
            var products = _storeRepository
                .Products
                .Skip((page - 1) * pageSize)//Pagination-sayfalama islemi icin
                .Select(
                    p=>new ProductViewModel
                    { 
                        Id= p.Id,
                        Name= p.Name,
                        Price = p.Price,
                        Description = p.Description,
                        Category= p.Category,
                    }).Take(pageSize);
            return View(new ProductListViewModel
            {
                Products = products,
                PageInfo = new PageInfo
                {
                    ItemsPerPage = pageSize,
                    TotalItems = _storeRepository.Products.Count()
                }
            });
        }
    }
}

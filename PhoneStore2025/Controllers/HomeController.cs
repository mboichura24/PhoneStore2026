using BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using UI.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HomeService _homeService;

        public HomeController(ILogger<HomeController> logger,
            HomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _homeService.GetAll();
            return View(items);
        }

        public async Task<IActionResult> Privacy()
        {
            return View();
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Core.Models;
using MVC_Core.Services;

namespace MVC_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IRepositorioPais Repositorio { get; }

        public HomeController(ILogger<HomeController> logger, IRepositorioPais repositorio)
        {
            _logger = logger;
            Repositorio = repositorio;
        }

        public IActionResult Index()
        {
            List<string> paises = Repositorio.ObtenerPaises();
            return View(paises);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

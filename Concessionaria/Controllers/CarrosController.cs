using Microsoft.AspNetCore.Mvc;
using Concessionaria.View.Models;
namespace Concessionaria.View.Controllers
{
    public class CarrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadCarros()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadCarros(Carros oCarros)
        {
            return View("DetalheCarros", oCarros);
        }
        

        
    }
}

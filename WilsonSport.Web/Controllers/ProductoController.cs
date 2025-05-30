using Microsoft.AspNetCore.Mvc;
using CapaLogica;

namespace WilsonSport.Web.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            var lista = ProductoLogica.Instancia.ObtenerProductos();
            return View(lista);
        }
    }
}

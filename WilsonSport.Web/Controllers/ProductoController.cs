using CapaEntidad;
using CapaLogica;
using Microsoft.AspNetCore.Mvc;

namespace WilsonSport.Web.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            List<producto> productos = ProductoLogica.Instancia.ObtenerProductos();
            return View(productos);
        }
    }
}

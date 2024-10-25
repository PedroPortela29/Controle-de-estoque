using Microsoft.AspNetCore.Mvc;

namespace Controle_de_EstoqueWEB.Controllers
{
    public class GraficoController : Controller
    {
        public IActionResult PerdaMes()
        {
            return View();
        }
        public IActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}

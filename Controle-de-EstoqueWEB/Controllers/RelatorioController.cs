using Microsoft.AspNetCore.Mvc;

namespace Controle_de_EstoqueWEB.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult PosicaoEstoque()
        {
            return View();
        }
        public IActionResult Ressuprimento()
        {
            return View();
        }
    }
}

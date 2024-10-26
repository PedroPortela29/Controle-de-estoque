using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_EstoqueWEB.Controllers
{
    public class RelatorioController : Controller
    {
        [Authorize]
        public IActionResult PosicaoEstoque()
        {
            return View();
        }

        [Authorize]
        public IActionResult Ressuprimento()
        {
            return View();
        }
    }
}

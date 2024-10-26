using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_EstoqueWEB.Controllers
{
    public class RelatorioController : Controller
    {
        [Authorize]
        public ActionResult PosicaoEstoque()
        {
            return View();
        }

        [Authorize]
        public ActionResult Ressuprimento()
        {
            return View();
        }
    }
}

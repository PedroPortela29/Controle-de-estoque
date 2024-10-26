using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_EstoqueWEB.Controllers
{
    public class GraficoController : Controller
    {
        [Authorize]
        public ActionResult PerdaMes()
        {
            return View();
        }

        [Authorize]
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}

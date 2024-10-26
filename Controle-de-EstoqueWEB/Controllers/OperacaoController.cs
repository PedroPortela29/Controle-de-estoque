using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_EstoqueWEB.Controllers
{
    public class OperacaoController : Controller
    {
        [Authorize]
        public ActionResult EntradaEstoque()
        {
            return View();
        }

        [Authorize]
        public ActionResult SaidaEstoque()
        {
            return View();
        }

        [Authorize]
        public ActionResult LancPerdaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult Inventario()
        {
            return View();
        }

    }
}

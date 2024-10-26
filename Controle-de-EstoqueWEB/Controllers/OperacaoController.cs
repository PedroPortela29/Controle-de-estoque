using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_EstoqueWEB.Controllers
{
    public class OperacaoController : Controller
    {
        [Authorize]
        public IActionResult EntradaEstoque()
        {
            return View();
        }

        [Authorize]
        public IActionResult SaidaEstoque()
        {
            return View();
        }

        [Authorize]
        public IActionResult LancPerdaProduto()
        {
            return View();
        }

        [Authorize]
        public IActionResult Inventario()
        {
            return View();
        }

    }
}

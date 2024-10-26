﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_EstoqueWEB.Controllers
{
    public class GraficoController : Controller
    {
        [Authorize]
        public IActionResult PerdaMes()
        {
            return View();
        }

        [Authorize]
        public IActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}

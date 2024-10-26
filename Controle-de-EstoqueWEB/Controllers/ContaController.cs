using Controle_de_EstoqueWEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_EstoqueWEB.Controllers
{
    public class ContaController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel login,string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            return View(login);
        }
    }
}

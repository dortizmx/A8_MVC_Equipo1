using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using A8UI.Data.Domain;
using A8UI.Data.IServices;
using System.Threading;

namespace A8_UI.Controllers
{
    public class LoginController : Controller
    {
        private IUsersService usersService;
        public LoginController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public IActionResult Index()
        {
            ViewBag.Error = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password, CancellationToken ct = default(CancellationToken))
        {
            //var user = await usersService.GetById(1, ct);
            var users = await usersService.GetByEmail(email, ct);
            if (users != null)
            {
                if (string.Equals(password, users.Contrasena))
                {
                    return RedirectToAction("index", "main");
                }               
            }
            ViewBag.Error = "Usuario Invalido";
            return View("Index");
        }

        
    }
}
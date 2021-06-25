using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using A8UI.Data.Domain;

namespace A8_UI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (!string.IsNullOrEmpty(email.Trim()) || !string.IsNullOrEmpty(password.Trim()))
            {
                //Valida usuario en base de datos
                var _user = getUser(email, password);
                RedirectToAction("index", "main");
                
            }
            return RedirectToAction("main");
        }

        private Users getUser(string email, string password)
        {
            Users retval = new Users();
            if (email == "dortizmx@gmail.com")
            {
                retval.Email = "dortizmx@gmail.com";
                retval.Nombre = "David";
                retval.ApellidoPaterno = "Ortiz";
                retval.ApellidoMaterno = "Mota";
                retval.Contraseña = "1234";
                retval.Id = 1;
                retval.Status = "AC";
            }
            else return null;
            return retval;

        }
    }
}
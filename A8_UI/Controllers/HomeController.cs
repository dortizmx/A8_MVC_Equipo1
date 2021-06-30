using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using A8_UI.Models;
using A8UI.Data.Domain;
using System.Threading;
using A8UI.Data.IServices;


namespace A8_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPacienteService pacienteService;

        public HomeController(ILogger<HomeController> logger, IPacienteService pacienteService)
        {
            _logger = logger;
            this.pacienteService = pacienteService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AgregaPaciente()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AgregaPaciente([FromForm] Paciente obj, CancellationToken ct = default(CancellationToken))
        {
            var retval = await pacienteService.Add(obj, ct);
            return View();
        }
        public IActionResult AgregarCita()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ObtinePacientes(CancellationToken ct = default(CancellationToken))
        {
            List<Paciente> pacientes = await pacienteService.GetAll(ct);
            ViewBag.Pacientes = "";
            return View();
        }
    }
}

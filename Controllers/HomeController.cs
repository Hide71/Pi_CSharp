using Microsoft.AspNetCore.Mvc;
using Pi_CSharp.Models;
using System.Diagnostics;

namespace Pi_CSharp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ClienteModel cliente = new();
            cliente.Nome = "Hideraldo";
            cliente.Endereco = "Rua Oraldo Machado, 25";
            cliente.Cpf = "123456789-22";
            cliente.Telefone = "(16) 992906784";
            return View(cliente);
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
    }
}

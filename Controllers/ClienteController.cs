using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Pi_CSharp.Repositorio;
using Pi_CSharp.Models;

namespace Pi_CSharp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(ClienteModel cliente){
            _clienteRepositorio.Adicionar(cliente);
            return RedirectToAction("index");  
        }
    }
}    
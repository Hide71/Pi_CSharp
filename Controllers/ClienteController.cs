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
           List<ClienteModel> clientes = _clienteRepositorio.BuscarTodos();
            return View(clientes);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            ClienteModel cliente = _clienteRepositorio.ListById(id);
            return View(cliente);
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
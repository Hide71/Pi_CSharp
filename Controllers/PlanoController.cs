using Microsoft.AspNetCore.Mvc;
using Pi_CSharp.Models;
using System.Diagnostics;
using Pi_CSharp.Repositorio;

namespace Pi_CSharp.Controllers{
    public class PlanoController : Controller{

        private readonly IPlanoRepositorio _planoRepositorio;

        public PlanoController(IPlanoRepositorio planoRepositorio){
            _planoRepositorio = planoRepositorio;

        }

        public IActionResult Index(){
            List<PlanoModel> plans = _planoRepositorio.Todos();
            return View(plans);
        }

        public IActionResult Add(){
            return View();
        }  

        public IActionResult Edit(int id){
            PlanoModel plan = _planoRepositorio.ListById(id);
            return View(plan);
        }  

        public IActionResult Delete(){
            return View();
        }
        [HttpPost] 
        public IActionResult Add(PlanoModel plan){
            if(ModelState.IsValid){
               _planoRepositorio.Adicionar(plan);
               return RedirectToAction("index");

            }
            return View(plan);
        }
        [HttpPost]
        public IActionResult Edit(PlanoModel plan){
            if(ModelState.IsValid){
                _planoRepositorio.Editar(plan);
                return RedirectToAction("index");
            } 
            return View(plan);   
        }    
    }

}
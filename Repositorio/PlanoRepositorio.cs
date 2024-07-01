using Pi_CSharp.Models;
using Pi_CSharp.Data;
using System.Collections.Generic;

namespace Pi_CSharp.Repositorio{

    public class PlanoRepositorio : IPlanoRepositorio{
        private readonly AppDbContext _appDbContext;

        public PlanoRepositorio(AppDbContext appDbContext){
            _appDbContext = appDbContext;


        }
        public List<PlanoModel> Todos(){
            return _appDbContext.Planos.ToList();
        }
 

        public PlanoModel Adicionar(PlanoModel plan){
           _appDbContext.Planos.Add(plan);
           _appDbContext.SaveChanges();
                return plan;
        }

    }
}
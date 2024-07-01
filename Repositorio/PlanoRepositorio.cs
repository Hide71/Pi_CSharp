using Pi_CSharp.Models;
using Pi_CSharp.Data;
using System.Collections.Generic;

namespace Pi_CSharp.Repositorio{

    public class PlanoRepositorio : IPlanoRepositorio{
        private readonly AppDbContext _appDbContext;

        public PlanoRepositorio(AppDbContext appDbContext){
            _appDbContext = appDbContext;


        }

        public PlanoModel ListById(int id){
            return _appDbContext.Planos.FirstOrDefault(p => p.Id == id);
        }
        public List<PlanoModel> Todos(){
            return _appDbContext.Planos.ToList();
        }
 

        public PlanoModel Adicionar(PlanoModel plan){
           _appDbContext.Planos.Add(plan);
           _appDbContext.SaveChanges();
                return plan;
        }
        public PlanoModel Editar(PlanoModel plan){
            PlanoModel planoBd = ListById(plan.Id);
            if(planoBd == null)
            throw new Exception("Erro ao Editar Plano!");
            
            planoBd.Plano = plan.Plano;
            planoBd.Cortes = plan.Cortes;
            planoBd.Barbas = plan.Barbas;
            planoBd.Valor = plan.Valor;
            _appDbContext.Planos.Update(planoBd);
            _appDbContext.SaveChanges();
            return planoBd;
        }

    }
}
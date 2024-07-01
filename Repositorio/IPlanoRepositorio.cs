using Pi_CSharp.Models;
using System.Collections.Generic;

namespace Pi_CSharp.Repositorio{
    public interface IPlanoRepositorio{
        PlanoModel Adicionar(PlanoModel plan);
        List<PlanoModel> Todos();
    }
}
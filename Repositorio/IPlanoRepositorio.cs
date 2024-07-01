using Pi_CSharp.Models;
using System.Collections.Generic;

namespace Pi_CSharp.Repositorio{
    public interface IPlanoRepositorio{
        PlanoModel ListById(int id);

        List<PlanoModel> Todos();

        PlanoModel Adicionar(PlanoModel plan);

        PlanoModel Editar(PlanoModel plan);
    }
}
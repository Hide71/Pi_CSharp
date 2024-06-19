using Pi_CSharp.Models;
using System.Collections.Generic;

namespace Pi_CSharp.Repositorio{

    public interface IClienteRepositorio

    {
        ClienteModel ListById(int id);
        List<ClienteModel> BuscarTodos();
        ClienteModel Adicionar(ClienteModel cliente);
        ClienteModel Editar(ClienteModel cliente);
    }
}
using Pi_CSharp.Models;
using System.Collections.Generic;

namespace Pi_CSharp.Repositorio{

    public interface IClienteRepositorio

    {
        List<ClienteModel> BuscarTodos();
        ClienteModel Adicionar(ClienteModel cliente);
    }
}
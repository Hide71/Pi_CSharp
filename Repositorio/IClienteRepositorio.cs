using Pi_CSharp.Models;

namespace Pi_CSharp.Repositorio{

    public interface IClienteRepositorio
    {
        ClienteModel Adicionar(ClienteModel cliente);
    }
}
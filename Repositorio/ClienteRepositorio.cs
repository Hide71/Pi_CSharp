using Pi_CSharp.Models;
using Pi_CSharp.Data;

namespace Pi_CSharp.Repositorio{

    public class ClienteRepositorio : IClienteRepositorio
    {  

        private readonly AppDbContext _appDbContext;
        public ClienteRepositorio(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            
        }
         public ClienteModel ListById(int id){
            return _appDbContext.Clientes.FirstOrDefault(x => x.Id == id);
         }


         public List<ClienteModel> BuscarTodos(){
            return _appDbContext.Clientes.ToList();
         }

        public ClienteModel Adicionar(ClienteModel cliente){
            _appDbContext.Clientes.Add(cliente);
            _appDbContext.SaveChanges();
                 return cliente;
            
        }
        public ClienteModel Editar(ClienteModel cliente){
            ClienteModel clienteBd = ListById(cliente.Id);
            if(clienteBd == null) 
            throw new Exception("Erro ao editar cliente!");
            clienteBd.Nome = cliente.Nome;
            clienteBd.Endereco = cliente.Endereco;
            clienteBd.Cpf = cliente.Cpf;
            clienteBd.Telefone = cliente.Telefone;
            clienteBd.Email = cliente.Email;

            _appDbContext.Clientes.Update(clienteBd);
            _appDbContext.SaveChanges();
            return clienteBd;
        }
        
    }
}
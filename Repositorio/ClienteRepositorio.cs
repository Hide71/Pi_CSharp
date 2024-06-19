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
        
    }
}
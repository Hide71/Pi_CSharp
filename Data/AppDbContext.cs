using Microsoft.AspNetCore;
using Pi_CSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace Pi_CSharp.Data
{
    public class AppDbContext: DbContext{

        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options){}

        public DbSet<ClienteModel> Clientes { get; set; }
     
    }

}   
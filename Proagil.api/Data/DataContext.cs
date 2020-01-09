using Microsoft.EntityFrameworkCore;
using Proagil.api.Model;

namespace Proagil.api.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base (options){} 
       public DbSet<Evento> Eventos{get; set;}
    //    toda vez que criar a uma tabela é so adicionar como a linha acima com dbset
    }
}
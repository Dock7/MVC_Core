using MVC_Core.Data;
using MVC_Core.Models;

namespace MVC_Core.Services
{
    public class PaisRepositorioEF : IRepositorioPais
    {
        public ApplicationDbContext DbContext { get; }

        public PaisRepositorioEF(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<Pais> ObtenerTodos()
        {
            return DbContext.Paises.ToList();
        }
    }
}

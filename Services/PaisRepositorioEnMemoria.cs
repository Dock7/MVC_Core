using MVC_Core.Models;

namespace MVC_Core.Services
{
    public class PaisRepositorioEnMemoria : IRepositorioPais
    {
        public List<Pais> ObtenerTodos()
        {
            var paises = new List<Pais>
            {
                new() { Id = 1, Nombre = "Argentina" },
                new() { Id = 2, Nombre = "Brasil" },
                new() { Id = 3, Nombre = "Chile" },
                new() { Id = 4, Nombre = "Uruguay" },
                new() { Id = 5, Nombre = "Paraguay" }
            };

            return paises;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVC_Core.Services;

namespace MVC_Core.ViewComponents
{
    public class PaisesViewComponent : ViewComponent
    {
        public IRepositorioPais RepositorioPais { get; }

        public PaisesViewComponent(IRepositorioPais repositorioPais)
        {
            RepositorioPais = repositorioPais;
        }

        public IViewComponentResult Invoke()
        {
            var paises = RepositorioPais.ObtenerTodos();
            return View(paises);
        }
    }
}

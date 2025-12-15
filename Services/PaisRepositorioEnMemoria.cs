namespace MVC_Core.Services
{
    public class PaisRepositorioEnMemoria : IRepositorioPais
    {
        public List<string> ObtenerPaises()
        {
            List<string> paises = [ "Argentina", "Brasil", "Chile", "Colombia", "México", "Perú", "Uruguay" ];
            return paises;
        }
    }
}

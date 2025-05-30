using CapaEntidad;
using CapaDatos;
using System.Collections.Generic;

namespace CapaLogica
{
    public class ProductoLogica
    {
        private static readonly ProductoLogica instancia = new ProductoLogica();
        public static ProductoLogica Instancia => instancia;

        public List<producto> ObtenerProductos()
        {
            return new ProductoDatos().ListarProductos();
        }
    }
}

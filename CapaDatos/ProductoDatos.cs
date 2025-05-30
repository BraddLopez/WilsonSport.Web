using CapaEntidad;
using CapaDatos;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace CapaDatos
{
    public class ProductoDatos
    {
        public List<producto> ListarProductos()
        {
            List<producto> lista = new List<producto>();

            using (SqlConnection cn = conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand("SELECT IdProducto, Nombre, Tipo, Precio FROM Producto", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new producto
                    {
                        IdProducto = (int)dr["IdProducto"],
                        Nombre = dr["Nombre"].ToString(),
                        Tipo = dr["Tipo"].ToString(),
                        Precio = (decimal)dr["Precio"]
                    });
                }
            }

            return lista;
        }
    }
}

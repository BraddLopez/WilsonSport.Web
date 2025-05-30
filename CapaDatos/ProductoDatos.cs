using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class ProductoDatos
    {
        public List<producto> ListarProductos()
        {
            List<producto> lista = new List<producto>();

            try
            {
                using (SqlConnection cn = conexion.Instancia.Conectar())
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarProductos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new producto
                        {
                            IdProducto = Convert.ToInt32(dr["IdProducto"]),
                            Nombre = dr["Nombre"].ToString(),
                            Tipo = dr["Tipo"].ToString(),
                            Precio = Convert.ToDecimal(dr["Precio"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos: " + ex.Message);
            }

            return lista;
        }

    }
}

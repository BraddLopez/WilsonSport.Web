﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class conexion
    {
        #region singleton
        private static readonly conexion UnicaInstancia = new conexion();
        public static conexion Instancia
        {
            get

            {
                return conexion.UnicaInstancia;
            }

        }
        #endregion singleton
        #region metodos
        public SqlConnection Conectar()

        {

            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = "Data Source=DESKTOP-46KF9NJ;initial Catalog=WilsonBD;" + "Integrated Security=true";

            return cn;

        }
        #endregion metodos
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CAPA_DATOS
{
    internal class CD_conexion
    {
        private SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion_DB"].ConnectionString);
        //metodo que me permite abrir la conexion de base de datos
        public SqlConnection Abrir()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        //metodo que me permite abrir la conexion de base de datos
        public SqlConnection Cerrar()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}

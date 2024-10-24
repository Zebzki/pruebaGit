using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace appAdsoM.datos
{
    public class CLConexion
    {
        SqlConnection conex = null;
        public CLConexion()
        {
            conex = new SqlConnection("Data Source=.;Initial Catalog=dbADSO;Integrated Security=True;");
            
        }
        public SqlConnection mtdAbrirConexion()
        {
            conex.Open();
            return conex;
        }
        public void mtdCerrarConexion()
        {
            conex.Close();
        }

    }
}
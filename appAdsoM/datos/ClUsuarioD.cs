using appAdsoM.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace appAdsoM.datos
{
    public class ClUsuarioD
    {
        /// <summary>
        /// metodo para verificar si el usuario existe en la base de datos
        /// </summary>
        /// <param name="user">recibe el email de usuario</param>
        /// <param name="pass">recibe el password de usuario</param>
        /// <returns>retorna true si el usuario existe</returns>
        public bool mtdIngresar(string user, string pass)
        {
            bool ingreso = false;
            string statement = "SELECT * FROM usuario WHERE email='" + user + "' AND  clave='" + pass + "'";
            CLConexion objConect = new CLConexion();
            SqlDataAdapter adapter = new SqlDataAdapter(statement, objConect.mtdAbrirConexion());
            DataTable tblData = new DataTable();
            adapter.Fill(tblData);
            objConect.mtdCerrarConexion();
            if (tblData.Rows.Count > 0)
            {
                ingreso = true;

            }
            return ingreso;

        }
        public ClUsuarioE mtdIngreso(ClUsuarioE objDatos)
        {
            string statement = "SELECT * FROM usuario WHERE email='" + objDatos.email + "' AND  clave='" + objDatos.clave + "'";
            CLConexion objConect = new CLConexion();
            SqlDataAdapter adapter = new SqlDataAdapter(statement, objConect.mtdAbrirConexion());
            DataTable tblData = new DataTable();
            adapter.Fill(tblData);
            objConect.mtdCerrarConexion();
            ClUsuarioE oDatosUser = null;
            if (tblData.Rows.Count>0)
            {
                oDatosUser = new ClUsuarioE();
                oDatosUser.idUsuario = int.Parse(tblData.Rows[0]["idUsuario"].ToString());
                oDatosUser.documento = tblData.Rows[0]["documento"].ToString();
                oDatosUser.nombres = tblData.Rows[0]["nombres"].ToString();
                oDatosUser.apellidos = tblData.Rows[0]["apellidos"].ToString();
                oDatosUser.email = tblData.Rows[0]["email"].ToString();
                oDatosUser.clave = tblData.Rows[0]["clave"].ToString();
 
            }

            return oDatosUser;
        }

        /// <summary>
        /// metodo con procedimiento almacenado para verificar si existe usuario
        /// </summary>
        /// <param name="objData">recibe el objeto</param>
        /// <returns>retorna todos los datos del registro si existe</returns>
        public ClUsuarioE mtdIngresoSP(ClUsuarioE objData)
        {
            ClUsuarioE oDatosUser = null;
            CLConexion objConect = new CLConexion();
            SqlConnection connection = objConect.mtdAbrirConexion();

            try
            {
                using (SqlCommand command = new SqlCommand("sp_ValidarUsuario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", objData.email);
                    command.Parameters.AddWithValue("@Clave", objData.clave);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oDatosUser = new ClUsuarioE
                            {
                                idUsuario = reader.GetInt32(reader.GetOrdinal("idUsuario")),
                                documento = reader.GetString(reader.GetOrdinal("documento")),
                                nombres = reader.GetString(reader.GetOrdinal("nombres")),
                                apellidos = reader.GetString(reader.GetOrdinal("apellidos")),
                                email = reader.GetString(reader.GetOrdinal("email")),
                                clave = reader.GetString(reader.GetOrdinal("clave"))
                            };
                        }
                    }
                }
            }
            finally
            {
                objConect.mtdCerrarConexion();
            }

            return oDatosUser;
        }
    }
}
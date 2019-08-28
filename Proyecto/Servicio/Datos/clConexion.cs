using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clConexion
    {
        SqlConnection objConexion = null;

        public clConexion()
        {
            try
            {
                objConexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\SGCPA2.mdf;Integrated Security=True");
            }          
            catch (Exception error)
            {
                string salida = error.Message;
            }
        }

        public int mtdConectado(string consulta)
        {
            objConexion.Open();
            SqlCommand comando = new SqlCommand(consulta, objConexion);
            int resultado = comando.ExecuteNonQuery();
            objConexion.Close();
            return resultado;
        }

        public DataSet mtdDesconectado(string consulta)
        {
            objConexion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, objConexion);
            DataSet dsDatos = new DataSet();
            adaptador.Fill(dsDatos, "tblDatos");
            objConexion.Close();
            return dsDatos;
        }

        public int mtdLogin(string Correo, string Clave)
        {
            clConexion objCo = new clConexion();

            Int32 IdUsuario = 0;
                SqlCommand Dat = new SqlCommand("Select IdUsuario,Nombre,Correo from Usuario where Correo= @correo and Clave= @clave " , objConexion);
            Dat.Parameters.AddWithValue("@correo", Correo);
            Dat.Parameters.AddWithValue("@clave", Clave);

            try
            {
                objConexion.Open();
                IdUsuario = (Int32)Dat.ExecuteScalar();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            SqlDataAdapter adapta = new SqlDataAdapter(Dat);
            DataTable Lo = new DataTable();
            adapta.Fill(Lo);
            int res = Lo.Rows.Count;

            objConexion.Close();
            return (int)IdUsuario;
        }
    }

}

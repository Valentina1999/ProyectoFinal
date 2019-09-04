using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clPregunta
    {
        public int IdPregunta { get; set; }
        public string Pregunta { get; set; }
        public string FechaP { get; set; }
        public int IdUsuario { get; set; }

        clConexion objConexion = new clConexion();

        public int mtdRegistrarPregunta(clPregunta objPregunta)
        {
            string consulta = "Insert Into Pregunta(Pregunta, FechaP, IdUsuario) values ('" + objPregunta.Pregunta + "', '" + objPregunta.FechaP + "'," + objPregunta.IdUsuario + ")";
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }

        public DataSet mtdListarPregunta()
        {
            string consulta = "Select Pregunta, FechaP, IdUsuarios from Pregunta";
            DataSet dsPregunta = new DataSet();
            clConexion objConexion = new clConexion();
            dsPregunta = objConexion.mtdDesconectado(consulta);
            return dsPregunta;
        }
    }
}
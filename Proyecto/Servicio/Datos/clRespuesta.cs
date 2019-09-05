using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clRespuesta
    {
        public int IdRespuesta { get; set; }
        public string Respuesta { get; set; }
        public string FechaR { get; set; }
        public int IdPregunta { get; set; }

        clConexion objConexion = new clConexion();

        public int mtdRegistrarRespuesta(clRespuesta objRespuesta)
        {
            string consulta = "Insert Into Respuesta(Respuesta, FechaR, IdPregunta) values ('" + objRespuesta.Respuesta + "', '" + objRespuesta.FechaR + "'," + objRespuesta.IdPregunta + ")";
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }
    }
}